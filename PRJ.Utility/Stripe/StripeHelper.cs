using PRJ.Utility.Stripe.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stripe;
using ServiceStack.Stripe;
using ServiceStack.Stripe.Types;
using Microsoft.Extensions.Options;

namespace PRJ.Utility.Stripe
{
    public class StripeHelper
    {

        static readonly StripeGateway gateway = new StripeGateway(StripeKey.ApiKey);

        #region Product
        public async static Task<string> CreateProduct(ProductDTO dto)
        {
            StripeConfiguration.ApiKey = StripeKey.ApiKey;
            var obj = new ProductCreateOptions
            {
                Name = dto.Name,
                Description = dto.Description,
            };
            var service = new ProductService();
            var response = await service.CreateAsync(obj);
            return response.Id;
        }
        public async static Task<string> UpdateProduct(ProductDTO dto)
        {
            StripeConfiguration.ApiKey = StripeKey.ApiKey;
            var obj = new ProductUpdateOptions
            {
                Name = dto.Name,
                Description = dto.Description,
            };
            var service = new ProductService();
            var response = service.Update(dto.ProductId, obj);
            return response.Id;
        }

        #endregion

        #region Price
        public async static Task<string> CreatePrice(PriceDTO dto)
        {
            StripeConfiguration.ApiKey = StripeKey.ApiKey;
            var obj = new PriceCreateOptions
            {
                Product = dto.ProductId,
                UnitAmountDecimal = dto.AmountDecimal * 100,
                Currency = dto.Currency,
                Active = true,
                Recurring = new PriceRecurringOptions
                {
                    Interval = dto.Interval,
                }
            };

            var service = new PriceService();
            var response = await service.CreateAsync(obj);

            return response.Id;
        }


        //public async static Task<string> UpdatePrice(PriceDTO dto)
        //{
        //    StripeConfiguration.ApiKey = StripeKey.ApiKey;
        //    var obj = new PriceUpdateOptions
        //    {
        //        UnitAmountDecimal = dto.AmountDecimal * 100,
                
        //        Active = dto.IsActive,
        //        Recurring = new PriceRecurringOptions
        //        {
        //            Interval = dto.Interval,
        //        }

        //    };

        //    var service = new PriceService();
        //    var response =  service.Update(dto.PriceId, obj);

        //    //     var response = await service.CreateAsync(obj);

        //    return response.Id;
        //}
        #endregion

        #region Plan
        public async static Task<string> CreatePlan(PlanStripeDTO dto)
        {
            StripeConfiguration.ApiKey = StripeKey.ApiKey;
            var obj = new PlanCreateOptions
            {
                Product = dto.ProductId,
                AmountDecimal = dto.AmountDecimal * 100,
                Currency = dto.Currency,
                Interval = dto.Interval
            };

            var service = new PlanService();
            var response = await service.CreateAsync(obj);
            return response.Id;
        }
        #endregion

        #region Create Customer
        public static string CreateCustomer(string email)
        {
            var customer = gateway.Post(new CreateStripeCustomerWithToken
            {
                Email = email
            });

            return customer.Id;
        }
        public static StripeSearchResult<Customer> SearchCustomer(string email)
        {
            StripeConfiguration.ApiKey = StripeKey.ApiKey;

            var options = new CustomerSearchOptions
            {
                Query = $@"email:'{email}'",
            };
            var service = new CustomerService();
            var obj = service.Search(options);

            return obj;
        }

        public static object GetCustomer(string customerId)
        {
            StripeConfiguration.ApiKey = StripeKey.ApiKey;

            var service = new CustomerService();
            var obj = service.Get(customerId);
            return obj;
        }

        //public static object UpdateCustomer(string customerId)
        //{
        //    StripeConfiguration.ApiKey = StripeKey.ApiKey;
        //    var service = new CustomerService();
        //    var options = new CustomerUpdateOptions
        //    {

        //    };
        
        //    var obj = service.Update(customerId, options);

        //    return obj;
        //}
        #endregion

        #region Subscription
        public static StripeSubscription CreateSubscription(string customerId, string priceId)
        {
            StripeConfiguration.ApiKey = StripeKey.ApiKey;
            var subscription = gateway.Post(new SubscribeStripeCustomer
            {
                CustomerId = customerId,
                Plan = priceId,
                Quantity = 1,
            });

            return subscription;
        }
        public static object CancelSubscription(string subscriptionId)
        {
            
            StripeConfiguration.ApiKey = StripeKey.ApiKey;

            var service = new SubscriptionService();
            var cancelled = service.Cancel(subscriptionId);

            return cancelled;

        }
        public static bool CheckSubscriptionExist(string subscriptionId)
        {

            var retrievedSubscription = gateway.Get(new GetStripeSubscription
            {
                SubscriptionId = subscriptionId
            });

            if (retrievedSubscription.Status != ServiceStack.Stripe.Types.StripeSubscriptionStatus.Canceled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async static Task<Subscription> UpdateSubscription(string subscriptionId, string priceId)
        {
            StripeConfiguration.ApiKey = StripeKey.ApiKey;

            var service = new SubscriptionService();
            Subscription subscription = service.Get(subscriptionId);

            var items = new List<SubscriptionItemOptions> {
                new SubscriptionItemOptions {
                    Id = subscription.Items.Data[0].Id,
                    Price = priceId,
                },
            };

            var options = new SubscriptionUpdateOptions
            {
                CancelAtPeriodEnd = false,
                ProrationBehavior = "none",
                Items = items,

            };
            subscription = service.Update(subscriptionId, options);
            

            return subscription;
        }
        public async static Task<Subscription> GetSubscription(string subscriptionId)
        {
            StripeConfiguration.ApiKey = StripeKey.ApiKey;

            var service = new SubscriptionService();
            Subscription subscription = service.Get(subscriptionId);

            return subscription;
        }

        #endregion




        #region Card
        public static StripeToken CreateCard(StripeCard card)
        {
            var cardToken = gateway.Post(new CreateStripeToken
            {
                Card = card,
            });

            StripeConfiguration.ApiKey = StripeKey.ApiKey;
            var options = new CardCreateOptions
            {
                Source = cardToken.Id
            };
            var service = new CardService();
            service.Create(card.Customer, options);

            return cardToken;
        }
        public static StripeReference DeleteCard(string customerId, string cardId)
        {
            var deletedRef = gateway.Delete(new DeleteStripeCustomerCard
            {
                CustomerId = customerId,
                CardId = cardId
            });

            return deletedRef;
        }
        public static StripeCollection<StripeCard> GetCustomerCard(string customerId)
        {
            var cards = gateway.Get(new GetStripeCustomerCards { CustomerId = customerId });
            return cards;
        }




        #endregion

        #region Charge
        public static string CreateChargeWithCustomerId(long amount, string customerId)
        {
            StripeConfiguration.ApiKey = StripeKey.ApiKey;

            var options = new ChargeCreateOptions
            {
                Amount = amount * 100,
                Currency = "usd",
                Customer = customerId
            };
            var service = new ChargeService();
            var charge = service.Create(options);
            return charge.Id;
        }
        public static Charge GetChargeDetail(string chargeId)
        {
            StripeConfiguration.ApiKey = StripeKey.ApiKey;
            var service = new ChargeService();
            var charge = service.Get(chargeId);
            return charge;
        }

        public static List<Charge> GetChargeIdListWithCustomerId(string customerId)
        {
            StripeConfiguration.ApiKey = StripeKey.ApiKey;
            var options = new ChargeListOptions
            {
                Customer = customerId
            };

            var service = new ChargeService();
            StripeList<Charge> charges = service.List(options);
            return charges.Data;
        }
        #endregion

        #region Customer Transaction
        public static List<CustomerBalanceTransaction> CustomerTransaction(string customerId)
        {
            StripeConfiguration.ApiKey = StripeKey.ApiKey;
            var options = new CustomerBalanceTransactionListOptions
            {
                Limit = 50,
            };
            var service = new CustomerBalanceTransactionService();
            var customerBalanceTransactions = service.List(customerId, options);

            var list = customerBalanceTransactions.ToList();
            return list;
        }
        #endregion

        #region MyRegion
        public static List<Invoice> CustomerInvoice(string customerId)
        {
            StripeConfiguration.ApiKey = StripeKey.ApiKey;
            var options = new InvoiceListOptions
            {
                Limit = 100,
                Customer = customerId,
            };
            var service = new InvoiceService();
            StripeList<Invoice> invoices = service.List(options);
            var list = invoices.ToList();
            return list;
        }
        #endregion
    }
}
