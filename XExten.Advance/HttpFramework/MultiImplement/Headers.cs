﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using XExten.Advance.HttpFramework.MultiCommon;
using XExten.Advance.HttpFramework.MultiInterface;
using XExten.Advance.HttpFramework.MultiOption;

namespace XExten.Advance.HttpFramework.MultiImplement
{
    internal class Headers : IHeaders
    {
        public IBuilders Build(Action<BuilderOption> action = null, Action<HttpClientHandler> handle = null)
        {
            return MultiConfig.Builder.Build(action, handle);
        }

        public ICookies AddCookie(Action<CookieOption> action)
        {
            return MultiConfig.Cookies.AddCookie(action);
        }

        public IHeaders AddHeader(Action<HeaderOption> action)
        {
            HeaderOption Option = new HeaderOption();
            action(Option);
            Option.SetHeader();
            return MultiConfig.Headers;
        }

        public INodes AddNode(Action<NodeOption> action)
        {
            return MultiConfig.Nodes.AddNode(action);
        }
    }
}
