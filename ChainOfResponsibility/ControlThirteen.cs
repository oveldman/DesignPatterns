using System;
using ChainOfResponsibility.Pattern;

namespace ChainOfResponsibility
{
    public class ControlThirteen
    {
        public void Run()
        {
            Bullit bullitOne = new Bullit(25, "Sniper Bullit");
            Bullit bullitTwo = new Bullit(11, "Machine Gun Bullit");
            Bullit bullitThree = new Bullit(4, "Pistol Bullit");

            Block waterBlock = new Water();
            Block woodBlock = new Wood();
            Block IronBlock = new Iron();

            waterBlock.SetSuccessor(woodBlock);
            woodBlock.SetSuccessor(IronBlock);

            waterBlock.Protect(bullitOne);
            waterBlock.Protect(bullitTwo);
            waterBlock.Protect(bullitThree);
        }
    }
}
