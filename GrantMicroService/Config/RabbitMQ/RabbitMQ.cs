﻿/*----------------------------------------------------------------
 Copyright (C) 2018 GrantMicroService (Grant 巩建春)  本软件的所有源码都可以免费的进行学习交流,切勿用于商业用途

 项目名称： GrantMicroService.Config
 文件名：   RabbitMQ
 创建者：   grant(巩建春) nnn987@126.com
 CLR版本：  4.0.30319.42000
 时间：     2018/4/19 13:13:10

 功能描述：

----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Text;

namespace GrantMicroService.Config
{
    /// <summary>
    /// RabbitMQ
    /// </summary>
    public class RabbitMQ
    {
        /// <summary>
        /// 
        /// </summary>
        public List<HostItem> Host { get; set; }
    }
}