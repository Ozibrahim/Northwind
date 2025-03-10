﻿using Newtonsoft.Json;

namespace Northwind.WebCoreUI.Extensions
{
    public static class SessionExtension
    {
        public static void setObject(this ISession session, string key, object value)
        {

            string json = JsonConvert.SerializeObject(value);
            session.SetString(key, json);

        }

        public static T getObject<T>(this ISession session, string key)
            where T : class
        {

            string json = session.GetString(key);
            if (string.IsNullOrEmpty(json))
            {
                return null;
            }
            return JsonConvert.DeserializeObject<T>(json);

        }
    }
}
