using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
	class BinaryTree
	{
		TreeNode root;

		public TreeNode find(int value)
		{
			if (root != null)
			{
				TreeNode node = root;
				while (node != null)
				{
					if (value == node.value)
					{
						break;
					}
					if (value < node.value)
					{
						node = node.left;
					}
					else if (value > node.value)
					{
						node = node.right;
					}
				}
				return node;
			}
			return null;
		}

		public void insert(int value)
		{
			if (root != null)
			{
				TreeNode node = root;
				while (node.value != value)
				{
					if (value > node.value)
					{
						if (node.right == null)
						{
							node.right = new TreeNode(value);
						}
						node = node.right;
					}
					else if (value < node.value)
					{
						if (node.left == null)
						{
							node.left = new TreeNode(value);
						}
						node = node.left;
					}
				}

			}
			else
			{
				root = new TreeNode(value);
			}
		}

		public void remove(int value)
		{
			if (root != null)
			{
				TreeNode parent = root;
				bool leaf = false;
				TreeNode child = null;
				bool isRoot = false;

				if (value == root.value)
				{
					isRoot = true;
					child = root;
				}
				else
				{
					isRoot = false;
					while (parent != null)
					{
						if (value < parent.value)
						{
							if (parent.left != null)
							{
								if (parent.left.value == value)
								{
									leaf = false;
									child = parent.left;
									break;
								}
								else
								{
									parent = parent.left;
								}
							}
							else
							{
								parent = parent.left;
							}
						}
						else if (value > parent.value)
						{
							if (parent.right != null)
							{
								if (parent.right.value == value)
								{
									leaf = true;
									child = parent.right;
									break;
								}
								else
								{
									parent = parent.right;
								}
							}
							else
							{
								parent = parent.right;
							}
						}
					}
				}

				if (child != null)
				{

					if (child.right != null)
					{
						TreeNode node = child.right;
						while (node.left != null)
						{
							node = node.left;
						}
						node.left = child.left;
						child = child.right;
					}
					else
					{
						child = child.left;
					}

					if (isRoot)
					{
						root = child;
					}
					else if (leaf)
					{
						parent.right = child;
					}
					else
					{
						parent.left = child;
					}
				}
			}
		}

		public void draw(Graphics g)
		{
			root.draw(g, 0, 0);
		}
	}
}
