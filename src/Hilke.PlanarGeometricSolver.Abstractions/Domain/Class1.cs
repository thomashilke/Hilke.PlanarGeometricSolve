namespace Hilke.PlanarGeometricSolver.Domain;

public class Point<Field>
{
    public Field X { get; }

    public Field Y { get; }
}

public class Direction<Field>
{
    public Field X { get; }

    public Field Y { get; }
}

public class Circle<Field>
{
    public Point<Field> Center { get; }

    public Field Radius { get; }
}

public class Line<Field>
{
    public Point<Field> Origin { get; }

    public Direction<Field> Direction { get; }
}

public enum ArcOrientation
{
    Clockwise = 1,
    CounterClockwise
}

public class Arc<Field>
{
    public Point<Field> Center { get; }

    public Field Radius { get; }

    public Direction<Field> StartDirection { get; }

    public Direction<Field> EndDirection { get; }

    public ArcOrientation Orientation { get; }
}

public class Segment<Field>
{
    public Point<Field> Origin { get; }

    public Direction<Field> Direction { get; }

    public Field Length { get; }
}
