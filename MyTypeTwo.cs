using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeOne
{
    public struct MyTypeTwo
    {
        public bool Enabled;
        public string Name;
        public uint Size;

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} - Enabled: {Enabled} - Name: {Name} - Size: {Size}";
        }
    }
}
