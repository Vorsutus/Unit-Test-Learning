namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            //simple buisness rules
            //three scenarios (execution paths) - when user, when admin, when someone else
            //if (user.IsAdmin)
            //    return true;

            //if (MadeBy == user)
            //    return true;

            //simple buisness rules (refactor 2)
            //if (user.IsAdmin || MadeBy == user) //rewrite code and test again to make sure everything still works
            //    return true;

            //return false;

            //simple buisness rules (refactor 3)
            return (user.IsAdmin || MadeBy == user); //rewrite code and test again to make sure everything still works
        }
        
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}