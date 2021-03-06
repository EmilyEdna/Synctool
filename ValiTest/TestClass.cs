﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XExten.Advance.ValidataFramework;
using XExten.Advance.ValidataFramework.Enum;

namespace ValiTest
{
    [ValitionClass(ModuleType = ValitionModuleEnum.Global)]
    public class TestClass
    {
        [Valition(CustomerValition = typeof(ValitionCustomer), ValiType = ValitionEnum.Customer, UsageAppendField = true)]
        public int Age { get; set; }
        [Valition(InfoMsg = "不能为空", UsageAppendField = true)]
        public string Name { get; set; }
    }
    public class ValitionCustomer : ValitionBaseCustomer
    {
        public override (bool Success, string Info) UserCustomerValition(string propertyName, string requestParam)
        {
            int.TryParse(requestParam, out int age);
            if (age == 0)
                return (false, "参数错误");
            return (true, "");
        }
    }
}
