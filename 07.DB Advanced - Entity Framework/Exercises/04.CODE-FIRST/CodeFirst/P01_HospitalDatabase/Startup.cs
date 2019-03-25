using System;
using P01_HospitalDatabase.Data;

namespace P01_HospitalDatabase
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            using (HospitalContext context = new HospitalContext())
            {
                context.Database.EnsureDeleted();

            }


        }
    }
}
