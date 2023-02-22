namespace ReizTechAssignment; 

public class Clock {
    public static void Main() {
        GetInput();
    }
    
    private static void GetInput() {
        Console.WriteLine("Enter the hour (0 - 11): ");
        var tryParse = int.TryParse(Console.ReadLine(), out var hour);
        if (tryParse == false || hour is < 0 or > 11) {
            Console.WriteLine("Invalid input");
            return;
        }
        
        Console.WriteLine("Enter the minute (0 - 59): ");
        tryParse = int.TryParse(Console.ReadLine(), out var minute);
        if (tryParse == false || minute is < 0 or > 59) {
            Console.WriteLine("Invalid input");
            return;
        }

        Console.WriteLine("The lesser angle is: " + CalculateLesserAngle(hour, minute));
    }

    private static float CalculateLesserAngle(int hour, int minute) {
        // calculate the angle of the hour hand (angle 0 is at 12 o'clock)
        // each hour is 360/12 = 30 degrees, each minute is 360/12/60 = 0.5 degrees
        var hourAngle = 30 * hour + 0.5f * minute;
        
        // calculate the angle of the minute hand (angle 0 is at 12 o'clock)
        // each minute is 360/60 = 6 degrees
        var minuteAngle = 6 * minute;
        
        // calculate the angle between the two hands
        var angle = Math.Abs(hourAngle - minuteAngle);
        
        // return the lesser angle
        return Math.Min(angle, 360 - angle);
    }
}