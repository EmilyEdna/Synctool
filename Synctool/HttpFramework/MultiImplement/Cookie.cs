﻿using Synctool.HttpFramework.MultiInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Synctool.HttpFramework.MultiImplement
{
    /// <summary>
    /// Cookie
    /// </summary>
    public class Cookies : ICookies
    {

        /// <summary>
        /// 构建
        /// </summary>
        /// <param name="TimeOut">超时:秒</param>
        /// <param name="UseHttps"></param>
        /// <returns></returns>
        public IBuilder Build(int TimeOut = 60, Boolean UseHttps = false)
        {
            return HttpMultiClientWare.Builder.Build(TimeOut, UseHttps);
        }

        /// <summary>
        /// Add Cookie
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public ICookies Cookie(string name, string value)
        {
            Cookie Cookie = new Cookie(name, value);
            HttpMultiClientWare.Container.Add(Cookie);
            return HttpMultiClientWare.Cookies;
        }

        /// <summary>
        /// Add Cookie
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public ICookies Cookie(string name, string value, string path)
        {
            Cookie Cookie = new Cookie(name, value, path);
            HttpMultiClientWare.Container.Add(Cookie);
            return HttpMultiClientWare.Cookies;
        }

        /// <summary>
        /// Add Cookie
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="path"></param>
        /// <param name="domain"></param>
        /// <returns></returns>
        public ICookies Cookie(string name, string value, string path, string domain)
        {
            Cookie Cookie = new Cookie(name, value, path, domain);
            HttpMultiClientWare.Container.Add(Cookie);
            return HttpMultiClientWare.Cookies;
        }

        /// <summary>
        /// Add Header
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public IHeaders Header(string key, string value)
        {
            return HttpMultiClientWare.Headers.Header(key, value);
        }

        /// <summary>
        /// Add Header
        /// </summary>
        /// <param name="headers"></param>
        /// <returns></returns>
        public IHeaders Header(Dictionary<string, string> headers)
        {
            return HttpMultiClientWare.Headers.Header(headers);
        }

        /// <summary>
        /// Add Path
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Type"></param>
        /// <param name="UseCache"></param>
        /// <param name="Weight"></param>
        /// <returns></returns>
        public INode AddNode(string Path, RequestType Type = RequestType.GET, bool UseCache = false, int Weight = 50)
        {
            return HttpMultiClientWare.Nodes.AddNode(Path, Type, UseCache, Weight);
        }

        /// <summary>
        /// Add Path
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Param"></param>
        /// <param name="Type"></param>
        /// <param name="UseCache"></param>
        /// <param name="Weight"></param>
        /// <returns></returns>
        public INode AddNode(string Path, string Param, RequestType Type = RequestType.GET, bool UseCache = false, int Weight = 50)
        {
            return HttpMultiClientWare.Nodes.AddNode(Path, Param, Type, UseCache, Weight);
        }

        /// <summary>
        /// Add Path
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Param"></param>
        /// <param name="Type"></param>
        /// <param name="UseCache"></param>
        /// <param name="Weight"></param>
        /// <returns></returns>
        public INode AddNode(string Path, List<KeyValuePair<String, String>> Param, RequestType Type = RequestType.GET, bool UseCache = false, int Weight = 50)
        {
            return HttpMultiClientWare.Nodes.AddNode(Path, Param, Type, UseCache, Weight);
        }

        /// <summary>
        /// Add Path
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Path"></param>
        /// <param name="Param"></param>
        /// <param name="MapFied"></param>
        /// <param name="Type"></param>
        /// <param name="UseCache"></param>
        /// <param name="Weight"></param>
        /// <returns></returns>
        public INode AddNode<T>(string Path, T Param, IDictionary<string, string> MapFied = null, RequestType Type = RequestType.GET, bool UseCache = false, int Weight = 50) where T : class, new()
        {
            return HttpMultiClientWare.Nodes.AddNode(Path, Param, MapFied, Type, UseCache, Weight);
        }
    }
}
