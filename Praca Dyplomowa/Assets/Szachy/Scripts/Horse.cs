public class Horse : BasicFigure
{
    public override void Move(string CurPos, string DestPos) {
        base.Move(CurPos, DestPos);
        StandardMoves.HorseMove(CurPos, DestPos);
   }
}
