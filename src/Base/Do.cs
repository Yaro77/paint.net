/////////////////////////////////////////////////////////////////////////////////
// Paint.NET                                                                   //
// Copyright (C) dotPDN LLC, Rick Brewster, Tom Jackson, and contributors.     //
// Portions Copyright (C) Microsoft Corporation. All Rights Reserved.          //
// See src/Resources/Files/License.txt for full licensing and attribution      //
// details.                                                                    //
// .                                                                           //
/////////////////////////////////////////////////////////////////////////////////

using System;

namespace PaintDotNet
{
    public static class Do
    {
        public static void Test<T>(
            T value,
            Function<bool, T> testFn,
            Action<T> ifTrueFn,
            Action<T> ifFalseFn)
        {
            (testFn(value) ? ifTrueFn : ifFalseFn)(value);
        }

        public static void GenerateTest<T>(
            Func<T> generate,
            Function<bool, T> test,
            Action<T> ifTrue,
            Action<T> ifFalse)
        {
            Test(generate(), test, ifTrue, ifFalse);
        }

        public static bool TryBool(Action actionAction)
        {
            try
            {
                actionAction();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }

        public static T TryCatch<T>(
            Func<T> actionFunction,
            Function<T, Exception> catchClause)
        {
            T returnVal;

            try
            {
                returnVal = actionFunction();
            }

            catch (Exception ex)
            {
                returnVal = catchClause(ex);
            }

            return returnVal;
        }
    }
}
