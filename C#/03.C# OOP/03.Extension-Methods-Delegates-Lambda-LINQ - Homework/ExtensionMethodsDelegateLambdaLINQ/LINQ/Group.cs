namespace ExtensionMethodsDelegateLambdaLINQ.LINQ
{
    public class Group
    {
        public Group(int groupNumber, string groupName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = groupName;
        }

        public int GroupNumber { get; set; }

        public string DepartmentName { get; set; }
    }
}
