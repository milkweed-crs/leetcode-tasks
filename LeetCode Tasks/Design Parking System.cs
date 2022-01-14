namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/design-parking-system/
    public static class DesignParkingSystem
    {
        public class ParkingSystem
        {
            private int _bigParkingSlots;
            private int _mediumParkingSlots;
            private int _smallParkingSlots;
            
            private const int BigCarType = 1;
            private const int MediumCarType = 2;
            private const int SmallCarType = 3;

            public ParkingSystem(int big,
                                 int medium,
                                 int small)
            {
                _bigParkingSlots = big;
                _mediumParkingSlots = medium;
                _smallParkingSlots = small;
            }

            public bool AddCar(int carType)
            {
                switch (carType)
                {
                    case BigCarType when _bigParkingSlots > 0:
                    {
                        _bigParkingSlots--;
                        return true;
                    }
                    case MediumCarType when _mediumParkingSlots > 0:
                    {
                        _mediumParkingSlots--;
                        return true;
                    }
                    case SmallCarType when _smallParkingSlots > 0:
                    {
                        _smallParkingSlots--;
                        return true;
                    }
                    
                    default:
                        return false;
                }
            }
        }
    }
}