using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
	internal class LLRBNode
	{
		public int Value { get; set; }
		public Color Color{ get; set; }
		public LLRBNode LeftChild { get; set; }
		public LLRBNode RightChild { get; set; }

		public override string ToString()
		{
			return String.Format("{Value: {0}, Color: {1}}", this.Value, this.Color);
		}
	}
}
