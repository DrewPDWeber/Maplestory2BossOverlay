using System.Collections.Generic;
using Newtonsoft.Json;
namespace MS2BossOverlay
{

    public class BossStructure
    {
        public string Name;
        public int Minutes;
        public string Map;
        public int Open;
    }

    class Bosses
    {
        public BossStructure[] Decode(string json)
        {
            var bosses = JsonConvert.DeserializeObject<List<BossStructure>>(json);
            return bosses.ToArray();
        }
    }
}
