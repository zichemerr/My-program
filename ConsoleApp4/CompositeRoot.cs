public class CompositeRoot
{
    private static void Main()
    {
        Calculator calculator = new Calculator();
        ProgramView programView = new ProgramView();
        Program program = new Program(calculator, programView);

        program.Work();
    }
}
