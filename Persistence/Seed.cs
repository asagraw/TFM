using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if(context.FundRaisers.Any()) return;

            var fundraisers = new List<Fundraiser>()
            {
                new Fundraiser
                {
                    Name = "Bhandara Hall",
                    Description = "Donation to build a bhandara hall to replace a makeshift hall for pooja feasts",
                    StartDate = System.DateTime.Now.AddDays(-5),
                    TargetAmount = 10000.00M,
                    CurrentAmount = 3000.00M,
                    Image = "lotus-temple-svgrepo-com.svg",
                    Contributors = new List<Contributor>()
                    {
                        new Contributor
                        {
                            Name = "Ashish Agrawal",
                            Email = "agashish85@gmail.com",
                            Mobile = "0432121342",
                            Donation = 1000.00M,
                            DateOfDonation = System.DateTime.Now.AddDays(-2),
                            Comment = "Here is my small contribution"
                        }
                    }
                },

                new Fundraiser
                {
                    Name = "Temple Parking Gate",
                    Description = "Donation to put up a gate to temple parking.",
                    StartDate = System.DateTime.Now.AddDays(-5),
                    TargetAmount = 10000.00M,
                    CurrentAmount = 3000.00M,
                    Image = "gate-svgrepo-com.svg",
                    Contributors = new List<Contributor>()
                    {
                        new Contributor
                        {
                            Name = "Sajal Agrawal",
                            Email = "sajal85@gmail.com",
                            Mobile = "0478773754",
                            Donation = 1000.00M,
                            DateOfDonation = System.DateTime.Now.AddDays(-2),
                            Comment = "Jai mata di"
                        }
                    }

                },

                new Fundraiser
                {
                    Name = "New fridge",
                    Description = "Donation to replace an old fridge",
                    StartDate = System.DateTime.Now.AddDays(-5),
                    TargetAmount = 5000.00M,
                    CurrentAmount = 1000.00M,
                    Image = "fridge-svgrepo-com.svg",
                    Contributors = new List<Contributor>()
                    {
                        new Contributor
                        {
                            Name = "Abalesh Agrawal",
                            Email = "abalesh85@gmail.com",
                            Mobile = "0478773755",
                            Donation = 1000.00M,
                            DateOfDonation = System.DateTime.Now.AddDays(-2),
                            Comment = "Jai maa kali.."
                        }
                    }

                }
            };
            await context.FundRaisers.AddRangeAsync(fundraisers);
            await context.SaveChangesAsync();
        }
    }
}