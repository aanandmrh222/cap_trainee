class _26_StudentCollection
{
    private string[] students = new string[3];

    public string GetStudent(int index)
    {
        return students[index];
    }

    public void SetStudent(int index, string name)
    {
        students[index] = name;
    }
}

class _26_Indexed_StudentCollection
{
    private string[] students = new string[3];

    public string this[int index]
    {
        get
        {
            return students[index];
        }

        set
        {
            students[index] = value;
        }
    }
}