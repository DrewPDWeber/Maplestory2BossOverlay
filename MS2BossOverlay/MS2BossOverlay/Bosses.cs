using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace MS2BossOverlay
{

    public class BossStructure
    {
        public string name;
        public int minutes;
        public string map;
        public int open;
    }

    class Bosses
    {
        public BossStructure[] decode(String json)
        {
            List<BossStructure> bosses = JsonConvert.DeserializeObject<List<BossStructure>>(json);
            return bosses.ToArray();
        }
    }
}
