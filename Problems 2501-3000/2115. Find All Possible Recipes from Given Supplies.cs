using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2101_2150
{
    internal class _2115
    {
        #region 10/8/2023
        public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies)
        {
            IList<string> answer = new List<string>();

            HashSet<string> found = new HashSet<string>();
            foreach (var item in supplies)
            {
                found.Add(item);
            }

            int count = answer.Count;
            while(true)
            {
                for (int i = 0; i < ingredients.Count; i++)
                {
                    if (found.Contains(recipes[i])) continue;
                    bool notfound = false;
                    for (int j = 0; j < ingredients[i].Count; j++)
                    {
                        if (!found.Contains(ingredients[i][j]))
                        {
                            notfound = true;
                            break;
                        }
                    }
                    if (!notfound)
                    {
                        answer.Add(recipes[i]);
                        found.Add(recipes[i]);
                    }
                }

                if (count == answer.Count) break;
                count = answer.Count;
            }
            
            return answer;  
        }
        #endregion

        #region Solution2

        #endregion
    }
}
