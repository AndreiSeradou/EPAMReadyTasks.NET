using System;

namespace SelectionStatments
{
    public static class Statements
    {
        /// <summary>
        /// Writes the largest of three numbers in a separate line in format "Number {0} is the largest".
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number.</param>
        /// <param name="third">Third number.</param>
        public static void WriteLargestWithNestedIfElse(int first, int second, int third)
        {
            // TODO #1: Add the method implementation. Restrictions:
            // - the method can only use the nested if...else statements;
            // - the method cannot use additional variables.
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine("Number {0} is the largest", first);
                }
            }

            if (second > first)
            {
                if (second > third)
                {
                    Console.WriteLine("Number {0} is the largest", second);
                }
            }
           
            if (third > first)
            {
                if (third > second)
                {
                    Console.WriteLine("Number {0} is the largest", third);
                }
            }

           
        }

        /// <summary>
        /// Writes the largest of three numbers in a separate line in format "Number {0} is the largest".
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number.</param>
        /// <param name="third">Third number.</param>
        public static void WriteLargestWithIfElseAndTernaryOperator(int first, int second, int third)
        {
            // TODO #2: Add the method implementation. Restrictions:
            // - the method can only use the if...else statement and ?: ternary operators;
            // - the method cannot use additional variables.
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine("Number {0} is the largest", first);
                }
                else
                {
                    Console.WriteLine((second > third) ? string.Format("Number {0} is the largest", second) : string.Format("Number {0} is the largest", third));
                }
            }
            else
            {
                Console.WriteLine((second > third) ? string.Format("Number {0} is the largest", second) : string.Format("Number {0} is the largest", third));
            }
            
        }

        /// <summary>
        /// Writes the largest of three numbers in a separate line in format "Number {0} is the largest".
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number.</param>
        /// <param name="third">Third number.</param>
        public static void WriteLargestWithIfElseAndConditionLogicalOperators(int first, int second, int third)
        {
            // TODO #3: Add the method implementation. Restrictions:
            // - the method can only use the if...else statement and conditional logical operators;
            // - the method cannot use additional variables.
            if (first > second && first > third)
            {
                Console.WriteLine("Number {0} is the largest", first);
            }
            else if (second > first && second > third)
            {
                Console.WriteLine("Number {0} is the largest", second);
            }
            else
            {
                Console.WriteLine("Number {0} is the largest", third);
            }
           
        }

        /// <summary>
        /// Writes the reaction to the user's age:
        /// - writes "Enjoy your retirement!" if user's age is more or equal 65;
        /// - writes "Fancy an alcoholic beverage?" if user's is age more or equal 21;
        /// - writes "You're old enough to drive." if user's is age more or equal 18;
        /// - writes "You are too young to drive, drink, or retire." otherwise.
        /// </summary>
        /// <param name="userAge">User's age is more or equals zero.</param>
        public static void HowOldAreYouReactionWithCascadedIfElse(int userAge)
        {
            // TODO #4: Add the method implementation. Restrictions: the method can only use the cascaded if...else statement.
            if (userAge > 65)
            {
                Console.WriteLine("Enjoy your retirement!");
            }
            else
            {
                if (userAge > 21)
                {
                    Console.WriteLine("Fancy an alcoholic beverage?");
                }
                else
                {
                    if (userAge > 18)
                    {
                        Console.WriteLine("You're old enough to drive.");
                    }
                    else
                    {
                        Console.WriteLine("You are too young to drive, drink, or retire.");
                    }
                }
            }
            
        }

        /// <summary>
        /// Writes the message with information about count of daily downloads:
        /// - writes "No downloads." if countOfDailyDownloads is less or equals 0;
        /// - writes "Daily downloads: 1-100." if countOfDailyDownloads is less than 100;
        /// - writes "Daily downloads: 100-1,000." if countOfDailyDownloads is less than 1000;
        /// - writes "Daily downloads: 1,000-10,000." if countOfDailyDownloads is less than 10000;
        /// - writes "Daily downloads: 10,000-100,000." if countOfDailyDownloads is less than 100000;
        /// - writes "Daily downloads: 100,000+." otherwise.
        /// </summary>
        /// <param name="countOfDailyDownloads">Count of daily downloads more or equals zero.</param>
        public static void WriteInformationAboutDailyDownloadsWithCascadedIfElse(int countOfDailyDownloads)
        {
            // TODO #5: Add the method implementation. Restrictions: the method can only use the cascaded if...else statement.
            if (countOfDailyDownloads <= 0)
            {
                Console.WriteLine("No downloads.");
            }
            else
            {
                if (countOfDailyDownloads < 100)
                {
                    Console.WriteLine("Daily downloads: 1-100.");
                }
                else
                {
                    if (countOfDailyDownloads < 1000)
                    {
                        Console.WriteLine("Daily downloads: 100-1,000.");
                    }
                    else
                    {
                        if (countOfDailyDownloads < 10000)
                        {
                            Console.WriteLine("Daily downloads: 1,000-10,000.");
                        }
                        else
                        {
                            if (countOfDailyDownloads < 100000)
                            {
                                Console.WriteLine("Daily downloads: 10,000-100,000.");
                            }
                            else
                            {
                                Console.WriteLine("Daily downloads: 100,000+.");
                            }
                        }
                    }
                }
            }
            
        }
        
        /// <summary>
        /// Writes on base on the DayOfWeek enumeration whether a particular date is
        /// - a weekend, writes "The weekend.";
        /// - the first day of the work week, writes "The first day of the work week.";
        /// - the last day of the work week, writes "The last day of the work week.";
        /// - the middle of the work week, "The middle of the work week.".
        /// </summary>
        /// <param name="dayOfWeek">Day of week.</param>
        public static void WriteTheInformationAboutDayWithIfElse(DayOfWeek dayOfWeek)
        {
            // TODO #6: Add the method implementation. Restriction: the method can only use the cascaded if...else statement and conditional logical operators.
            if (dayOfWeek == DayOfWeek.Sunday || dayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("The weekend.");
            }
            else
            {
                if (dayOfWeek == DayOfWeek.Monday)
                {
                    Console.WriteLine("The first day of the work week.");
                }
                else
                {
                    if (dayOfWeek == DayOfWeek.Friday)
                    {
                        Console.WriteLine("The last day of the work week.");
                    }
                    else
                    {
                        Console.WriteLine("The middle of the work week.");
                    }
                }
            }

            
        }
        
        /// <summary>
        /// Determines on base on the DayOfWeek enumeration whether a particular date is
        /// - a weekend, writes "The weekend.";
        /// - the first day of the work week, writes "The first day of the work week.";
        /// - the last day of the work week, writes "The last day of the work week.";
        /// - the middle of the work week, "The middle of the work week.".
        /// </summary>
        /// <param name="dayOfWeek">Day of week.</param>
        public static void WriteTheInformationAboutDayWithSwitchStatement(DayOfWeek dayOfWeek)
        {
            // TODO #7: Add the method implementation. Restriction: the method can only use the switch statement.
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("The weekend.");
                    break;

                case DayOfWeek.Monday:
                    Console.WriteLine("The first day of the work week.");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the work week.");
                    break;

                default:
                    Console.WriteLine("The middle of the work week.");
                    break;
            }

            
        }

        /// <summary>
        /// Gets the message with information about the type of integer in format:
        /// - "{arg} is sbyte.", if arg is sbyte;
        /// - "{arg} is byte.", if arg is byte;
        /// - "{arg} is short.", if arg is short;
        /// - "{arg} is int.", if arg is int;
        /// - "{arg} is long.", if arg is long;
        /// - "{arg} is ushort.", if arg is ushort;
        /// - "{arg} is uint.", if arg is uint;
        /// - "{arg} is ulong.", if arg is ulong.
        /// - "{arg} is not integer.", otherwise.
        /// </summary>
        /// <param name="arg">Presents some integer.</param>
        /// <returns>The message with information about the type of integer.</returns>
        public static string GetTypeOfIntegerWithCascadedIfElse(object arg)
        {
            // TODO #8: Add the method implementation. Restrictions: the method can only use the cascaded if...else statement.  
            if (arg.GetType() == typeof(SByte))
            {
               return arg.ToString() + " is sbyte.";
            }
            else
            {
                if (arg.GetType() == typeof(Byte))
                {
                    return arg.ToString() + " is byte.";
                }
                else
                {
                    if (arg.GetType() == typeof(Int16))
                    {
                        return arg.ToString() + " is short.";
                    }
                    else
                    {
                        if (arg.GetType() == typeof(Int32))
                        {
                            return arg.ToString() + " is int.";
                        }
                        else
                        {
                            if (arg.GetType() == typeof(Int64))
                            {
                                return arg.ToString() + " is long.";
                            }
                            else
                            {
                                if (arg.GetType() == typeof(UInt16))
                                {
                                    return arg.ToString() + " is ushort.";
                                }
                                else
                                {
                                    if (arg.GetType() == typeof(UInt32))
                                    {
                                        return arg.ToString() + " is uint.";
                                    }
                                    else
                                    {
                                        if (arg.GetType() == typeof(UInt64))
                                        {
                                            return arg.ToString() + " is ulong.";
                                        }
                                        else
                                        {
                                            return arg.ToString() + " is not integer.";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
        }

        /// <summary>
        /// Gets the message with information about the type of integer in format:
        /// - "{arg} is sbyte.", if arg is sbyte;
        /// - "{arg} is byte.", if arg is byte;
        /// - "{arg} is short.", if arg is short;
        /// - "{arg} is int.", if arg is int;
        /// - "{arg} is long.", if arg is long;
        /// - "{arg} is ushort.", if arg is ushort;
        /// - "{arg} is uint.", if arg is uint;
        /// - "{arg} is ulong.", if arg is ulong.
        /// - "{arg} is not integer.", otherwise.
        /// </summary>
        /// <param name="arg">Presents some integer.</param>
        /// <returns>The message with information about the type of integer.</returns>
        public static string GetTypeOfIntegerWithSwitchStatement(object arg)
        {
            // TODO #9: Add the method implementation. Restrictions: the method can only use the switch statement.
            switch (Type.GetTypeCode(arg.GetType()))
            {
                case TypeCode.SByte:
                    return arg.ToString() + " is sbyte.";
                   
                case TypeCode.Byte:
                    return arg.ToString() + " is byte.";

                case TypeCode.Int16:
                    return arg.ToString() + " is short.";

                case TypeCode.Int32:
                    return arg.ToString() + " is int.";
                   
                case TypeCode.Int64:
                    return arg.ToString() + " is long.";

                case TypeCode.UInt16:
                    return arg.ToString() + " is ushort.";

                case TypeCode.UInt32:
                    return arg.ToString() + " is uint.";

                case TypeCode.UInt64:
                    return arg.ToString() + " is ulong.";

                default:
                    return arg.ToString() + " is not integer.";
            }

            
        }

        /// <summary>
        /// Gets the message with information about the type of integer in format:
        /// - "{arg} is sbyte.", if arg is sbyte;
        /// - "{arg} is byte.", if arg is byte;
        /// - "{arg} is short.", if arg is short;
        /// - "{arg} is int.", if arg is int;
        /// - "{arg} is long.", if arg is long;
        /// - "{arg} is ushort.", if arg is ushort;
        /// - "{arg} is uint.", if arg is uint;
        /// - "{arg} is ulong.", if arg is ulong.
        /// - "{arg} is not integer.", otherwise.
        /// </summary>
        /// <param name="arg">Presents some integer.</param>
        /// <returns>The message with information about the type of integer.</returns>
        public static string GetTypeOfIntegerWithSwitchExpression(object arg) => Type.GetTypeCode(arg.GetType()) switch
        {

            // TODO #10: Add the method implementation. Restrictions: the method can only use the switch expression.
            TypeCode.SByte=> arg.ToString() + " is sbyte.",
            TypeCode.Byte => arg.ToString() + " is byte.",
            TypeCode.Int16 => arg.ToString() + " is short.",
            TypeCode.Int32 => arg.ToString() + " is int.",
            TypeCode.Int64 => arg.ToString() + " is long.",
            TypeCode.UInt16 => arg.ToString() + " is ushort.",
            TypeCode.UInt32 => arg.ToString() + " is uint.",
            TypeCode.UInt64 => arg.ToString() + " is ulong.",
            _ => arg.ToString() + " is not integer.",
           
        };

        /// <summary>
        /// Writes the season that corresponds to the given month:
        /// - writes "It's winter now." if month is December, January or February;
        /// - writes "It's spring now." if month is March, April or May;
        /// - writes "It's summer now." if month is June, July or August;
        /// - writes "It's autumn now." if month is September, October or November;
        /// - writes "Sorry, the month was entered incorrectly." otherwise.
        /// </summary>
        /// <param name="month">Source month.</param>
        public static void WriteTheInformationAboutSeasonsWithSwitchStatement(Month month)
        {
            // TODO #11: Add the method implementation. Restrictions: the method can only use the switch statement.
            switch (month)
            {
                case Month.December:
                case Month.January:
                case Month.February:
                    Console.WriteLine("It's winter now.");
                    break;

                case Month.March:
                case Month.April:
                case Month.May:
                    Console.WriteLine("It's spring now.");
                    break;

                case Month.June:
                case Month.July:
                case Month.August:
                    Console.WriteLine("It's summer now.");
                    break;

                case Month.September:
                case Month.October:
                case Month.November:
                    Console.WriteLine("It's autumn now.");
                    break;

                default:
                    Console.WriteLine("Sorry, the month was entered incorrectly.");
                    break;
            }

           
        }

        /// <summary>
        /// Returns the length of the integer's string presentation.
        /// </summary>
        /// <param name="number">Source integer.</param>
        /// <returns>The length of the integer's string presentation.</returns>
        public static byte GetLengthWithCascadedIfElse(int number)
        {
            // TODO #12: Add the method implementation. Restriction: the method can only use the cascaded if...else statement and comparison operations.
            if (number <= 9 && number >= -9)
            {
                return 1;
            }
            else
            {
                if (number <= 99 && number > 9 || number >= -99 && number < -9)
                {
                    return 2;
                }
                else
                {
                    if (number <= 999 && number > 99 || number >= -999 && number < -99)
                    {
                        return 3;
                    }
                    else
                    {
                        if (number <= 9999 && number > 999 || number >= -9999 && number < -999)
                        {
                            return 4;
                        }
                        else
                        {
                            if (number <= 99999 && number > 9999 || number >= -99999 && number < -9999)
                            {
                                return 5;
                            }
                            else
                            {
                                if (number <= 999999 && number > 99999 || number >= -999999 && number < -99999)
                                {
                                    return 6;
                                }
                                else
                                {
                                    if (number <= 9999999 && number > 999999 || number >= -9999999 && number < -999999)
                                    {
                                        return 7;
                                    }
                                    else
                                    {
                                        if (number <= 99999999 && number > 9999999 || number >= -99999999 && number < -9999999)
                                        {
                                            return 8;
                                        }
                                        else
                                        {
                                            if (number <= 999999999 && number > 99999999 || number >= -999999999 && number < -99999999)
                                            {
                                                return 9;
                                            }
                                            else
                                            {
                                                return 10;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

           
        }
        
        /// <summary>
        /// Returns the length of the integer's string presentation.
        /// </summary>
        /// <param name="number">Source integer.</param>
        /// <returns>The length of the integer's string presentation.</returns>
        public static byte GetLengthWithSwitchExpression(int number) => Math.Abs((long)number).ToString().Length switch
        {
            // TODO #13: Add the method implementation. Restriction: the method can only use the switch expression and comparison operations.
            1 => 1,
            2 => 2,
            3 => 3,
            4 => 4,
            5 => 5,
            6 => 6,
            7 => 7,
            8 => 8,
            9 => 9,
            _ => 10,
        };
        
        /// <summary>
        /// Returns the value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or
        /// null, if integer less than 1 or more than 12.
        /// </summary>
        /// <param name="month">Source integer.</param>
        /// <returns>The value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or null, if integer less than 1 or more than 12.
        /// </returns>
        public static Month? GetMonthWithCascadedIfElse(int month)
        {
            // TODO #14: Add the method implementation. Restriction: the method can only use the cascaded if...else statement.
            
                if (month == 1)
                {
                    return Month.January;
                }
                else
                {
                    if (month == 2)
                    {
                        return Month.February;
                    }
                    else
                    {
                        if (month == 3)
                        {
                            return Month.March;
                        }
                        else
                        {
                            if (month == 4)
                            {
                                return Month.April;
                            }
                            else
                            {
                                if (month == 5)
                                {
                                    return Month.May;
                                }
                                else
                                {
                                    if (month == 6)
                                    {
                                        return Month.June;
                                    }
                                    else
                                    {
                                        if (month == 7)
                                        {
                                            return Month.July;
                                        }
                                        else
                                        {
                                            if (month == 8)
                                            {
                                                return Month.August;
                                            }
                                            else
                                            {
                                                if (month == 9)
                                                {
                                                    return Month.September;
                                                }
                                                else
                                                {
                                                    if (month == 10)
                                                    {
                                                        return Month.October;
                                                    }
                                                    else
                                                    {
                                                        if (month == 11)
                                                        {
                                                            return Month.November;
                                                        }
                                                        else
                                                        {
                                                            if (month == 12)
                                                            {
                                                                return Month.December;
                                                            }
                                                            else
                                                            {
                                                                return null;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
        }

        /// <summary>
        /// Returns the value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or
        /// null, if integer less than 1 or more than 12.
        /// </summary>
        /// <param name="month">Source integer.</param>
        /// <returns>The value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or null, if integer less than 1 or more than 12.
        /// </returns>
        public static Month? GetMonthWithSwitchStatement(int month)
        {
            // TODO #15: Add the method implementation. Restriction: the method can only use the switch statement.
            switch (month)
            {
                case 1:
                    return Month.January;
                case 2:
                    return Month.February;
                case 3:
                    return Month.March;
                case 4:
                    return Month.April;
                case 5:
                    return Month.May;
                case 6:
                    return Month.June;
                case 7:
                    return Month.July;
                case 8:
                    return Month.August;
                case 9:
                    return Month.September;
                case 10:
                    return Month.October;
                case 11:
                    return Month.November;
                case 12:
                    return Month.December;

                default:
                    return null;
            }
        }

        /// <summary>
        /// Returns the value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or
        /// null, if integer less than 1 or more than 12.
        /// </summary>
        /// <param name="month">Source integer.</param>
        /// <returns>The value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or null, if integer less than 1 or more than 12.
        /// </returns>
        public static Month? GetMonthWithSwitchExpression(int month) => month switch
        {
            // TODO #16: Add the method implementation. Restriction: the method can only use the switch expression.
            1 => Month.January,
            2 => Month.February,
            3 => Month.March,
            4 => Month.April,
            5 => Month.May,
            6 => Month.June,
            7 => Month.July,
            8 => Month.August,
            9 => Month.September,
            10 => Month.October,
            11 => Month.November,
            12 => Month.December,
            _ => null,
        };
    }
}

