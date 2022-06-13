using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Avatar.Models
{
    public class Fighters
    {
        [Key]
        public int FighterID { get; set; }
        public string BenderName { get; set; }      
        public string City { get; set; }       
        public string Weapon { get; set; }   
        public string FightingStyles { get; set; }
    }
}
