using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace leetcode.Problems
{
    class _0088
    {
        #region answer1
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0) {
                for(int i =0; i < n; i++)
                {
                    nums1[i] = nums2[i];
                }
                return;
            }
      
            for (int i = 0; i < n; i++)
            {
                if (nums2[i] >= nums1[m + i - 1])
                {
                    nums1[m + i] = nums2[i];
                }
                else
                {
                    for (int j = 0; j < m + i; j++)
                    {
                        if (nums2[i] <= nums1[j])
                        {
                            int lastIndx = m + i;
                            while (lastIndx > j)
                            {
                                nums1[lastIndx] = nums1[lastIndx - 1];
                                lastIndx--;
                            }
                            nums1[j] = nums2[i];
                            break;
                        }
                    }
                }
                logArry(nums1);


            }
        }
        #endregion

        #region 3 pointers
        //****************** 3 pointers ********************
        public void Merge_V2(int[] nums1, int m, int[] nums2, int n) {
            int p1 = m - 1;
            int p2 = n - 1;
            for(int p = m + n - 1; p >= 0; p--)
            {
                if (p2 < 0) break;

                if (p1>=0 && nums1[p1] >= nums2[p2])
                {
                    nums1[p] = nums1[p1];
                    p1--;
                }
                else
                {
                    nums1[p] = nums2[p2];
                    p2--;
                }
            }
        }
        #endregion

        #region 12/29/2021
        //-----12-29-2021------
        public void Merge_R2(int[] nums1,int m, int[] nums2,int n)
        {
            if (m == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    nums1[i] = nums2[i];
                }
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (nums2[i] >= nums1[m + i - 1])
                {
                    nums1[m + i] = nums2[i];
                }
                else
                {
                    for (int j = 0; j < m + i; j++)
                    {
                        if (nums2[i] <= nums1[j])
                        {
                            int lastIndx = m + i;
                            while (lastIndx > j)
                            {
                                nums1[lastIndx] = nums1[lastIndx - 1];
                                lastIndx--;
                            }
                            nums1[j] = nums2[i];
                            break;
                        }
                    }
                }
            }
        }
        public void logArry(int[] a)
        {
            foreach (var s in a)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region 02/05/2022
        //02/05/2022
        public void Merge_R3(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;
            int p3 = m + n - 1;
            while (p2 >= 0)
            {
                if (p1 >= 0)
                {
                    if (nums1[p1] > nums2[p2])
                    {
                        nums1[p3] = nums1[p1];
                        p1--;
                    }
                    else
                    {
                        nums1[p3] = nums2[p2];
                        p2--;
                    }

                }
                else
                {
                    nums1[p3] = nums2[p2];
                    p2--;
                }
                p3--;
            }
        }
        #endregion

        #region 08/11/2022
        public void Merge_20220811(int[] nums1, int m, int[] nums2, int n)
        {
            int position = nums1.Length - 1;
            int i = m - 1;
            int j = n - 1;
            while (i >= 0 || j >= 0)
            {
                if (j < 0)
                {
                    nums1[position] = nums1[i];
                    i--;
                }
                else if (i < 0)
                {
                    nums1[position] = nums2[j];
                    j--;
                }
                else if (nums1[i] > nums2[j])
                {
                    nums1[position] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[position] = nums2[j];
                    j--;
                }
                position--;
            }

        }
        #endregion

        #region 08/07/2023
        public void Merge_20230807(int[] nums1, int m, int[] nums2, int n)
        {
            int l1 = m - 1;
            int l2 = n - 1;
            int currentIndex = nums1.Length - 1;

            while (currentIndex >= 0)
            {
                if(l1 < 0)
                {
                    nums1[currentIndex] = nums2[l2];
                    l2--;
                }else if(l2 < 0)
                {
                    nums1[currentIndex] = nums1[l1];
                    l1--;
                }else if (nums1[l1] > nums2[l2])
                {
                    nums1[currentIndex] = nums1[l1];
                    l1--;
                }
                else
                {
                    nums1[currentIndex] = nums2[l2];
                    l2--;
                }

                currentIndex--;
            }
        }
        #endregion

        #region 03/17/2024
        public void Merge_2024_03_17(int[] nums1, int m, int[] nums2, int n)
        {
            int index = nums1.Length - 1;
            int l1 = m - 1;
            int l2 = n - 1;
            while (l1 >= 0 || l2 >= 0)
            {
                if(l1 < 0)
                {
                    nums1[index--] = nums2[l2--];
                }else if(l2 < 0)
                {
                    nums1[index--] = nums1[l1--];
                }
                else
                {
                    if (nums1[l1] > nums2[l2])
                    {
                        nums1[index--] = nums1[l1--];
                    }
                    else
                    {
                        nums1[index--] = nums2[l2--];
                    }
                }
            }
        }
            #endregion

        }
    }
