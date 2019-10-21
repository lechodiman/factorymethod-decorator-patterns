using System;
using System.Collections.Generic;

namespace exercise1
{
    public abstract class AbstractClientFactory
    {
        public abstract IClient CreateClient();
    }

    public class UniformClientFactory : AbstractClientFactory
    {
        public int NumberOfInstances = 0;

        public override IClient CreateClient()
        {
            var random = new Random();
            var clientOptions = new List<IClient> { new YoungClient(), new AdultClient(), new OldClient() };
            var randomIndex = random.Next(clientOptions.Count);
            NumberOfInstances += 1;
            clientOptions[randomIndex].id = NumberOfInstances;
            return clientOptions[randomIndex];

            // int randomInt = random.Next(3);
            // if (randomInt == 0)
            // {
            //     return new YoungClient();
            // }
            // else if (randomInt == 1)
            // {
            //     return new AdultClient();
            // }
            // else
            // {
            //     return new OldClient();
            // }
        }
    }
}
