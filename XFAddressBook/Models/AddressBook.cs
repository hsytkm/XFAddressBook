using System;
using System.Collections.Generic;
using System.Linq;

namespace XFAddressBook.Models
{
    class AddressBook
    {
        private static readonly IList<IContact> Relatives =
            new List<IContact>()
            {
                new Phone("Uncle", "012-3456-7890"),
            };

        private static readonly IList<IContact> Friends =
            new List<IContact>()
            {
                new Address("Junior", "Osaka city"),
                new Phone("High", "000-0000-0000"),
                new Email("Collage", "friend@collage.ac.jp"),
            };

        private static readonly IList<IContact> Coworkers =
            new List<IContact>()
            {
                new Email("Chief", "chief@company.com"),
                new Phone("Boss", "654-3210"),
            };

        public static readonly IDictionary<string, IList<IContact>> GroupBook =
            new Dictionary<string, IList<IContact>>()
            {
                [nameof(Relatives)] = Relatives,
                [nameof(Friends)] = Friends,
                [nameof(Coworkers)] = Coworkers,
            };

    }
}
