using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class TreeNode
    {
        //Переменная для символов
        private char Data { get; set; }

        //Левый узел дерева
        private TreeNode Left { get; set; }

        //Правый узел дерева
        private TreeNode Right { get; set; }
        //Сортировка всей строки
        public static string TreeSort(char[] array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }

            return new string(treeNode.Transform());
        }
        //Добавление в переменную символом
        private TreeNode(char data)
        {
            Data = data;
        }

        //Добавление символов в узлы дерева
        private void Insert(TreeNode node)
        {
            if (node.Data < Data)
            {
                if (Left == null) Left = node;
                else Left.Insert(node);
            }
            else
            {
                if (Right == null) Right = node;
                else Right.Insert(node);
            }
        }

        //преобразование дерева в отсортированный массив
        private char[] Transform(List<char> elements = null)
        {
            if (elements == null) elements = new List<char>();

            if (Left != null) Left.Transform(elements);

            elements.Add(Data);

            if (Right != null) Right.Transform(elements);

            return elements.ToArray();
        }
    }
}
