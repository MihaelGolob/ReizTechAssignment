namespace ReizTechAssignment; 

public class Tree {
   public static void Main() {
      // create the provided tree:
      // 1. level (root)
      var tree = new Branch(); 
      // 2. level
      tree.Branches.Add(new Branch());
      tree.Branches.Add(new Branch());
      // 3. level
      tree.Branches[0].Branches.Add(new Branch());
      tree.Branches[1].Branches.Add(new Branch());
      tree.Branches[1].Branches.Add(new Branch());
      tree.Branches[1].Branches.Add(new Branch());
      // 4. level
      tree.Branches[1].Branches[0].Branches.Add(new Branch());
      tree.Branches[1].Branches[1].Branches.Add(new Branch());
      tree.Branches[1].Branches[1].Branches.Add(new Branch());
      // 5. level
      tree.Branches[1].Branches[1].Branches[0].Branches.Add(new Branch());

      Console.WriteLine("The tree's depth is: " + TreeDepth(tree));
   }

   private static int TreeDepth(Branch tree) {
      if (tree.Branches.Count == 0)
         return 1;
      
      var maxDepth = 1;
      foreach (var branch in tree.Branches) {
         var branchDepth = TreeDepth(branch);
         maxDepth = Math.Max(maxDepth, branchDepth);
      }
      
      return maxDepth + 1;
   }

}