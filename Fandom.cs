using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fandoms.Data
{
    public class Fandom
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FID { get; set; }
        public string Fcolor { get; set; }

        public int Fname { get; set; }
        public DateTime Date { get; set; }
        public int SID { get; set; }

        
        [ForeignKey("SID")]
        public order Id { get; set; }
        [ForeignKey("Onumber")]
        public stock Ordernum  { get; set; }
        public order Orders { get; internal set; }
    }
}
