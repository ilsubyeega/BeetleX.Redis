﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeetleX.Redis.Commands
{
    public class LPUSH : Command
    {
        public LPUSH(string key, IDataFormater dataFormater)
        {
            DataFormater = dataFormater;
            Key = key;
        }

        public string Key { get; set; }

        public List<object> Values { get; set; } = new List<object>();

        public override bool Read => false;

        public override string Name => "LPUSH";

        public override void OnExecute()
        {
            base.OnExecute();
            AddText(Key);
            for (int i = 0; i < Values.Count; i++)
                AddData(Values[i]);
        }
    }
}
