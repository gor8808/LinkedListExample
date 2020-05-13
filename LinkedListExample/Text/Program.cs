using System;
using System.Collections.Generic;
using System.Linq;

namespace Text
{
    public class Node
    {
        public int data { get; set; }
        public Node next { get; set; }
        public Node prev { get; set; }
        public Node(int data)
        {
            this.data = data;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 1, 5, 10, 50, 60 };
            //string s = "abc";
            //string sa = "aabcds";
            //bool a = sa.Contains(s);
            //Console.WriteLine(a);
            //var arr = sa.ToCharArray();
            //arr[2] = '_';
            //sa = arr.ToString();    

            //string s1 = "aabcc";
            //string s2 = "adcaa";
            //int result = 0;
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    if (s2.IndexOf(s1[i]) != -1)
            //    {
            //        result++;
            //        s2 = CharToString(s2,s2.IndexOf(s1[i]));
            //    }
            //}
            //Console.WriteLine(result); 

            //int n = 1230;


            //int sum1 = 0;
            //int sum2 = 0;
            //string number = Convert.ToString(n);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (i < number.Length / 2)
            //    {
            //        sum1 += Convert.ToInt32(number[i] + "");
            //    }
            //    else
            //    {
            //        sum2 += Convert.ToInt32(number[i] + "");
            //    }
            //}
            //if (sum1 == sum2) return true;
            //else return false;
            //Console.WriteLine(sum1);
            //Console.WriteLine(sum2);


            //int[] a = new int[] { -1, 150, 190, 170, -1, -1, 160, 180 };


            //List<int> arr = new List<int>();
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] != -1)
            //    {
            //        arr.Add(a[i]);
            //        a[i] = 0;
            //    }
            //}
            //arr.Sort();
            //int j = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if(a[i] == 0)
            //    {
            //        a[i] = arr[j];
            //        j++;
            //    }
            //}
            //foreach (var item in a)
            //{
            //    Console.Write(item + " ");
            //}


            //string inputString = "foo(bar(baz))blim";
            //string result = reverseInParentheses(inputString);
            //Console.WriteLine(result);


            //int[] arr = new int[] { 100, 51, 50, 100 };
            //int[] result = alternatingSums(arr);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i] + " ");
            //}

            //string[] arr = new string[] { "abc","ded"};
            //string[] result = addBorder(arr);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}
            int[] arr = new int[] { 1, 1, 1 };
            int result = arrayChange(arr);
            Console.WriteLine(arr);
            //Node head = new Node(list[0]);
            //Node recoverHead = head;
            //for (int i = 1; i < list.Count; i++)
            //{
            //    head.next = new Node(list[i]);
            //    head = head.next;
            //}
            //PrintNode(recoverHead);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        public static int arrayChange(int[] inputArray)
        {
            Array.Sort(inputArray);
        }

        public static string[] addBorder(string[] picture)
        {
            int len = picture[0].Length;
            string[] result = new string[picture.Length + 2];
            for (int i = 0; i < result.Length; i++)
            {
                if(i == 0 || i == result.Length - 1)
                {
                    result[i] = new string('*', len);
                    continue;
                }
                else
                {
                    result[i] = "*" + picture[i - 1] + "*";
                }
            }
            return result;
        }

        public static int[] alternatingSumsOld(int[] a)
        {
            int[] result = new int[2];
            for (int i = 0; i < a.Length; i++)
            {
                if ((i - 1) % 2 == 0)
                {
                    result[1] += a[i];
                }
                if(i % 2 == 0)
                {
                    result[0] += a[i];
                }
            }
            return result;
        }
        public static int[] alternatingSums(int[] a)
        {
            int[] result = new int[2];
            for (int i = 0; i < a.Length; i++)
            {
                result[i % 2] += a[i];
            }
            return result;
        }

        public static string reverseInParentheses(string str)
        {
            int lid = str.LastIndexOf('(');
            if (lid == -1)
            {
                return str;
            }
            else
            {
                int rid = str.IndexOf(')', lid);

                return reverseInParentheses(
                      str.Substring(0, lid)
                    + new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray())
                    + str.Substring(rid + 1)
                );
            }

        }
        public static string reverseInParenthesesOld(string inputString)
        {
            while (inputString.Contains("("))
            {
                int i = inputString.LastIndexOf("(");
                var s = new string(inputString.Skip(i + 1).TakeWhile(x => x != ')').Reverse().ToArray());
                var t = "(" + new string(s.Reverse().ToArray()) + ")";
                inputString = inputString.Replace(t, s);
            }
            return inputString;
        }
        public static string reverseInParenthesesOld2(string inputString)
        {
            return reverse(inputString);
        }
        public static string reverse(string s)
        {

            var l = s.LastIndexOf('(');

            if (l == -1)
            {
                return s;
            }

            var r = s.IndexOf(')', l);

            var arr = s.Substring(l + 1, r - l - 1).ToCharArray();

            Array.Reverse(arr);

            return reverse(s.Substring(0, l) + new string(arr) + s.Substring(r + 1));

        }
        private static string CharToString(string s2, int index)
        {
            string result = string.Empty;
            for (int i = 0; i < s2.Length; i++)
            {
                if (i == index)
                {
                    result += '_';
                }
                else
                {
                    result += s2[i];
                }
            }
            return result;
        }

        private static void PrintNode(Node recoverHead)
        {
            while (recoverHead != null)
            {
                Console.Write(recoverHead.data + " ");
                recoverHead = recoverHead.next;
            }
        }
    }
}
