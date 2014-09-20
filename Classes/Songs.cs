using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSync
{
    class Songs
    {
        public string name { get; set; }
        public int playlist_ID { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string file_file_name { get; set; }
        public string file_content_type { get; set; }
        public int file_file_size { get; set; }
        public DateTime file_updated_at { get; set; }
    }
}
