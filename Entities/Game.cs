using System;

namespace Entities {
    public class Game {
        public int Id { get; set; }
        public int DmId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string GameName { get; set; }
        public bool Closed { get; set; } = false;

    }
}
