﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
	internal class LLRBTRee
	{
		public LLRBNode Root { get; set; }
		public void AddChild(int value)
		{
			if(Root != null)
			{
				AddChild(Root, value);
				Root = Rebalance(Root);
				Root.Color = Color.BLACK;
			}
			else
			{
				Root = new LLRBNode();
				Root.Color = Color.BLACK;
				Root.Value = value;
			}
		}
		private void AddChild(LLRBNode node, int value)
		{
			if (node.Value == value)
				return;
			else
			{
				if(node.LeftChild != null)
				{
					AddChild(node.LeftChild, value);
					node.LeftChild = Rebalance(node.LeftChild);
				}
			}
		}

		private LLRBNode Rebalance(LLRBNode node)
		{
			LLRBNode result = node;
			bool needRebalance = false;

			do
			{
				if(result.RightChild != null  
					&& result.RightChild.Color == Color.RED 
					&& (result.LeftChild == null || result.Color == Color.BLACK))
				{
					needRebalance =	true;
					result = RightSwap(result);
				}
				if(result.LeftChild != null
					&& result.LeftChild.Color == Color.RED
					&&(result.RightChild == null || result.Color == Color.RED))
				{
					needRebalance = true;
					result = LeftSwap(result);
				}
				if(result.LeftChild != null
					&& result.LeftChild.Color == Color.RED
					&& result.RightChild != null
					&& result.RightChild.Color == Color.RED)
				{
					needRebalance = true;
					ColorSwap(result);
				}
			} while(needRebalance);
			return result;
		}

		private LLRBNode RightSwap(LLRBNode node)
		{
			LLRBNode rightChild = node.RightChild;
			LLRBNode betweenNode = rightChild.LeftChild;
			rightChild.LeftChild = node;
			node.RightChild = betweenNode;
			rightChild.Color = node.Color;
			node.Color = Color.RED;

			return rightChild;
		}
		private LLRBNode LeftSwap(LLRBNode node)
		{
			LLRBNode leftChild = node.RightChild;
			LLRBNode betweenNode = leftChild.LeftChild;
			leftChild.RightChild = node;
			node.LeftChild = betweenNode;
			leftChild.Color = node.Color;
			node.Color = Color.RED;

			return leftChild;
		}
		private void ColorSwap(LLRBNode node)
		{
			node.RightChild.Color = Color.BLACK;
			node.LeftChild.Color = Color.RED;
			node.Color = Color.RED;
		}
	}
}
