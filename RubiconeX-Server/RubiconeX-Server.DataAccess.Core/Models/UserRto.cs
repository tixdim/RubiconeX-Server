using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RubiconeX_Server.DataAccess.Core.Models
{
    [Table("User")]
    public class UserRto
    {
      [Key]  public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronumic { get; set; }

        public string AvatarUrl { get; set; }

        public string Introdution { get; set; }

        public UserRoleRto Role { get; set; }


        [NotMapped]
        public string GetFullName
        {
            get => LastName + " " + FirstName + " " + Patronumic;
        }
    }
}
