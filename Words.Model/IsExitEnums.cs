namespace Words.Model
{
    public class IsExitEnums: ICheckIsExit
    {
        public bool IsExit(string input)
        {
            if ((input == "Q") || (input == "q") || (input == "й") || (input == "Й"))
            {
                return true;
            }
            return false;
        }
    }
}
