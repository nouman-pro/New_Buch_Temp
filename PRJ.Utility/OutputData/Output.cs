using System.Net;

namespace PRJ.Utility.OutputData;
public static class Output
{
    public static OutputDTO<T> Handler<T>(int responseCode, T dto , int? TotalCount = 0)
    {
        var obj = new OutputDTO<T>()
        {
            Data = dto,
            TotalData = TotalCount.HasValue ? TotalCount.Value : 0,
        };

        switch (responseCode)
        {
            case ResponseCode.GET:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Message = ResponseMessage.GET;
                break;

            case ResponseCode.USER_CREATE:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Message = ResponseMessage.USER_CREATE;
                break;
            case ResponseCode.RECORD_CREATE:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Message = ResponseMessage.RECORD_CREATE;
                break;

            case ResponseCode.RECORD_UPDATE:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Message = ResponseMessage.RECORD_UPDATE;
                break;
            case ResponseCode.RECORD_DELETE:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Message = ResponseMessage.DELETE;
                break;
            case ResponseCode.USER_DELETE:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Message = ResponseMessage.USER_DELETE;
                break;

            case ResponseCode.GET_USER:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Message = ResponseMessage.GET_USER;
                break;

            case ResponseCode.GET_ALL_USERS:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Message = ResponseMessage.GET_ALL_USERS;
                break;

            case ResponseCode.USER_EXIST:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.Conflict);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.USER_EXIST;
                break;

            case ResponseCode.USER_NOT_FOUND:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.USER_NOT_FOUND;
                break;

            case ResponseCode.NOT_FOUND:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.NOT_FOUND;
                break;

            case ResponseCode.SUCCESSFULLY_REGISTER:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Succeeded = true;
                obj.Message = ResponseMessage.SUCCESSFULLY_REGISTER;
                break;

            case ResponseCode.EMAIL_EXIST:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.Conflict);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.EMAIL_EXIST;
                break;
            case ResponseCode.PHONE_EXIST:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.Conflict);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.PHONE_EXIST;
                break;
            case ResponseStatusCode.BAD_REQUEST:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.BAD_REQUEST;
                break;
            case ResponseCode.SUCCESSFULLY_LOGIN:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Succeeded = true;
                obj.Message = ResponseMessage.SUCCESSFULLY_LOGIN;
                break;

            case ResponseCode.INVALID_CREDENTIALS:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.INVALID_CREDENTIALS;
                break;
            case ResponseCode.BLOCKED_USER:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.BLOCKED_USER;
                break;
            case ResponseCode.PASSWORD_UPDATED:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Succeeded = true;
                obj.Message = ResponseMessage.PASSWORD_UPDATED;
                break;
            case ResponseCode.OTP_VERIFIED:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Succeeded = true;
                obj.Message = ResponseMessage.OTP_VERIFIED;
                break;
            case ResponseCode.EMAIL_VERIFIED:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Succeeded = true;
                obj.Message = ResponseMessage.EMAIL_VERIFIED;
                break;
            case ResponseCode.OTP_SENT:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Succeeded = true;
                obj.Message = ResponseMessage.OTP_SENT;
                break;
            case ResponseCode.WRONG_OTP:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.WRONG_OTP;
                break;
            case ResponseCode.SLOT_ALREADY_EXIST:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.SLOT_ALREADY_EXIST;
                break;
            case ResponseCode.Total_Slots_Time_Is_Less_Than_DurationPlusGap:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.Total_Slots_Time_Is_Less_Than_DurationPlusGap;
                break;
            case ResponseCode.Reason_Required:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.Reason_Required;
                break;
            case ResponseCode.Appointment_Already_Booked:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.Appointment_Already_Booked;
                break;
            case ResponseCode.Your_Appointment_Not_Booked_Yet:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.Your_Appointment_Not_Booked_Yet;
                break;
            case ResponseCode.Your_Appointment_Cant_be_Canceled:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.Your_Appointment_Cant_be_Canceled;
                break;
            case ResponseCode.ACCOUNT_REJECTED:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.ACCOUNT_REJECTED;
                break;
            case ResponseCode.ACCOUNT_SUSPENDED:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.ACCOUNT_SUSPENDED;
                break;
            case ResponseCode.Strip_CustomerId_Not_Generated_Yet:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.Strip_CustomerId_Not_Generated_Yet;
                break;
            case ResponseCode.Strip_Card_Not_Added:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.Strip_Card_Not_Added;
                break;
            case ResponseCode.Subscription_Already_Canceled:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.Subscription_Already_Canceled;
                break;
            case ResponseCode.Subscription_Canceled:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Succeeded = true;
                obj.Message = ResponseMessage.Subscription_Canceled;
                break;
            case ResponseCode.Strip_SubscriptionId_Not_Generated_Yet:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.Strip_SubscriptionId_Not_Generated_Yet;
                break;
            case ResponseCode.FamilyMember_Created:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.OK);
                obj.Succeeded = true;
                obj.Message = ResponseMessage.FamilyMember_Created;
                break;
            case ResponseCode.RECORD_Already__Exist:
                obj.HttpStatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                obj.Succeeded = false;
                obj.Message = ResponseMessage.RECORD_Already__Exist;
                break;


        }

        return obj;
    }
}
