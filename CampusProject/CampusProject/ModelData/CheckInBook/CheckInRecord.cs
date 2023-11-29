internal class CheckInRecord
{
    public Citizen Person { get; }
    public Room Room { get; }

    public CheckInRecord(Citizen person, Room room)
    {
        Person = person;
        Room = room;
    }
}