﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Synctool.HttpFramework.MultiInterface
{
    /// <summary>
    /// 构建
    /// </summary>
    public interface IBuilder
    {
        /// <summary>
        /// 构建
        /// </summary>
        /// <param name="TimeOut">超时:秒</param>
        /// <param name="UseHttps"></param>
        /// <returns></returns>
        IBuilder Build(int TimeOut=60,Boolean UseHttps=false);
        /// <summary>
        /// 设置缓存时间
        /// </summary>
        /// <param name="CacheSeconds"></param>
        /// <returns></returns>
        IBuilder CacheTime(int CacheSeconds = 60);
        /// <summary>
        /// 执行 default UTF-8
        /// </summary>
        /// <param name="LoggerExcutor"></param>
        /// <returns></returns>
        List<String> RunString(Action<String, Stopwatch> LoggerExcutor = null);
        /// <summary>
        /// 执行 default UTF-8
        /// </summary>
        /// <param name="LoggerExcutor"></param>
        /// <returns></returns>
        Task<List<String>> RunStringAsync(Action<String, Stopwatch> LoggerExcutor = null);
        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="LoggerExcutor"></param>
        /// <returns></returns>
        List<Byte[]> RunBytes(Action<Byte[], Stopwatch> LoggerExcutor = null);
        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="LoggerExcutor"></param>
        /// <returns></returns>
        Task<List<Byte[]>> RunBytesAsync(Action<Byte[], Stopwatch> LoggerExcutor = null);
    }
}
