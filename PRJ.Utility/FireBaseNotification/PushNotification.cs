using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PRJ.Utility.FireBaseNotification
{
    public static class PushNotification
    {
        //Single Obj
        //public static PushResponseDto Send(string deviceId, int deviceTypeId, dynamic message, string title, string senderName = null)
        //{
        //    string applicationID = PushNotificationConfiguration.firebaseServerKey;
        //    string senderId = PushNotificationConfiguration.firebaseSenderId;
        //    WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
        //    tRequest.Method = "post";
        //    tRequest.ContentType = "application/json";
        //    var json = "";
        //    dynamic notificationData;
        //    if (senderName is null)
        //    {
        //        notificationData = new
        //        {
        //            body = message,
        //            title = "IntelyHealth",
        //            type = 1,
        //            badge = 1
        //        };
        //    }
        //    else
        //    {
        //        notificationData = new
        //        {
        //            body = message,
        //            title = "IntelyHealth",
        //            badge = 1,
        //            type = 1,
        //            sendername = senderName
        //        };
        //    }

        //    var payload = new
        //    {
        //        to = deviceId,
        //        priority = "high",
        //        content_available = true,
        //        notification = notificationData,
        //        data = new
        //        {
        //            body = message,
        //            title = "IntelyHealth",
        //            type = 1
        //        }
        //    };
        //    json = JsonConvert.SerializeObject(payload).ToString();

        //    Byte[] byteArray = Encoding.UTF8.GetBytes(json);
        //    tRequest.Headers.Add(string.Format("Authorization: key={0}", applicationID));
        //    tRequest.Headers.Add(string.Format("Sender: id={0}", senderId));
        //    tRequest.ContentLength = byteArray.Length;
        //    string str = "";
        //    using (Stream dataStream = tRequest.GetRequestStream())
        //    {
        //        dataStream.Write(byteArray, 0, byteArray.Length);
        //        using (WebResponse tResponse = tRequest.GetResponse())
        //        {
        //            using (Stream dataStreamResponse = tResponse.GetResponseStream())
        //            {
        //                using (StreamReader tReader = new StreamReader(dataStreamResponse))
        //                {
        //                    String sResponseFromServer = tReader.ReadToEnd();
        //                    str = sResponseFromServer;
        //                }
        //            }
        //        }
        //    }
        //    return new PushResponseDto() { RequestString = json, Status = str };
        //}

        public static PushResponseDto Send(string deviceId, dynamic message, string title, int typeId)
        {
            string applicationID = PushNotificationConfiguration.firebaseServerKey;
            string senderId = PushNotificationConfiguration.firebaseSenderId;
            WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
            tRequest.Method = "post";
            tRequest.ContentType = "application/json";
            var json = "";
            dynamic notificationData = new
            {

                body = message,
                title = "IntelyHealth",
                // type = typeId,

            };

            var payload = new
            {
                registration_ids = deviceId,
                priority = "high",
                content_available = true,
                notification = notificationData,
                data = notificationData,
            };
            json = JsonConvert.SerializeObject(payload).ToString();

            Byte[] byteArray = Encoding.UTF8.GetBytes(json);
            tRequest.Headers.Add(string.Format("Authorization: key={0}", applicationID));
            tRequest.Headers.Add(string.Format("Sender: id={0}", senderId));
            tRequest.ContentLength = byteArray.Length;
            string str = "";
            using (Stream dataStream = tRequest.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
                using (WebResponse tResponse = tRequest.GetResponse())
                {
                    using (Stream dataStreamResponse = tResponse.GetResponseStream())
                    {
                        using (StreamReader tReader = new StreamReader(dataStreamResponse))
                        {
                            String sResponseFromServer = tReader.ReadToEnd();
                            str = sResponseFromServer;
                        }
                    }
                }
            }
            return new PushResponseDto() { RequestString = json, Status = str };
        }
        public static PushResponseDto SendToMultiple(List<string> deviceId, dynamic message, string title, int typeId)
        {
            string applicationID = PushNotificationConfiguration.firebaseServerKey;
            string senderId = PushNotificationConfiguration.firebaseSenderId;
            WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
            tRequest.Method = "post";
            tRequest.ContentType = "application/json";
            var json = "";
            dynamic notificationData = new
            {

                body = message,
                title = "IntelyHealth",
               // type = typeId,

            };

            var payload = new
            {
                registration_ids = deviceId,
                priority = "high",
                content_available = true,
                notification = notificationData,
                data = notificationData,
            };
            json = JsonConvert.SerializeObject(payload).ToString();

            Byte[] byteArray = Encoding.UTF8.GetBytes(json);
            tRequest.Headers.Add(string.Format("Authorization: key={0}", applicationID));
            tRequest.Headers.Add(string.Format("Sender: id={0}", senderId));
            tRequest.ContentLength = byteArray.Length;
            string str = "";
            using (Stream dataStream = tRequest.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
                using (WebResponse tResponse = tRequest.GetResponse())
                {
                    using (Stream dataStreamResponse = tResponse.GetResponseStream())
                    {
                        using (StreamReader tReader = new StreamReader(dataStreamResponse))
                        {
                            String sResponseFromServer = tReader.ReadToEnd();
                            str = sResponseFromServer;
                        }
                    }
                }
            }
            return new PushResponseDto() { RequestString = json, Status = str };
        }


        //public static PushResponseDto SendToMultipleOnAndroid(List<string> deviceId, dynamic message, string title, int type, long?
        //                                    requestId, string destiAddress, string pickAddress, string senderName = null)
        //{
        //    string applicationID = PushNotificationConfiguration.firebaseServerKey;
        //    string senderId = PushNotificationConfiguration.firebaseSenderId;
        //    WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
        //    tRequest.Method = "post";
        //    tRequest.ContentType = "application/json";
        //    var json = "";
        //    dynamic notificationData;
        //    if (senderName is null)
        //    {
        //        notificationData = new
        //        {
        //            body = message,
        //            title = "IntelyHealth",
        //            type = type,
        //            badge = 1,
        //            currentRequestId = requestId,
        //            destinationAddress = destiAddress,
        //            pickupAddress = pickAddress
        //        };
        //    }
        //    else
        //    {
        //        notificationData = new
        //        {
        //            body = message,
        //            title = "IntelyHealth",
        //            badge = 1,
        //            type = type,
        //            sendername = senderName,
        //            currentRequestId = requestId,
        //            destinationAddress = destiAddress,
        //            pickupAddress = pickAddress
        //        };
        //    }

        //    var payload = new
        //    {
        //        registration_ids = deviceId,
        //        priority = "high",
        //        content_available = true,
        //        data = new
        //        {
        //            body = message,
        //            title = "IntelyHealth",
        //            type = type,
        //            currentRequestId = requestId,
        //            destinationAddress = destiAddress,
        //            pickupAddress = pickAddress
        //        }
        //    };
        //    json = JsonConvert.SerializeObject(payload).ToString();

        //    Byte[] byteArray = Encoding.UTF8.GetBytes(json);
        //    tRequest.Headers.Add(string.Format("Authorization: key={0}", applicationID));
        //    tRequest.Headers.Add(string.Format("Sender: id={0}", senderId));
        //    tRequest.ContentLength = byteArray.Length;
        //    string str = "";
        //    using (Stream dataStream = tRequest.GetRequestStream())
        //    {
        //        dataStream.Write(byteArray, 0, byteArray.Length);
        //        using (WebResponse tResponse = tRequest.GetResponse())
        //        {
        //            using (Stream dataStreamResponse = tResponse.GetResponseStream())
        //            {
        //                using (StreamReader tReader = new StreamReader(dataStreamResponse))
        //                {
        //                    String sResponseFromServer = tReader.ReadToEnd();
        //                    str = sResponseFromServer;
        //                }
        //            }
        //        }
        //    }
        //    return new PushResponseDto() { RequestString = json, Status = str };
        //}
    }
}
