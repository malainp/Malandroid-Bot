using System;
namespace MalandroidBot.Core.TravisCI
{
    public class TravisCIBuildResultMessage
    {

        /*
         *  Pending: A build has been requested
         *  Passed: The build completed successfully
         *  Fixed: The build completed successfully after a previously failed build
         *  Broken: The build completed in failure after a previously successful build
         *  Failed: The build is the first build for a new branch and has failed
         *  Still Failing: The build completed in failure after a previously failed build
         *  Canceled: The build was canceled
         *  Errored: The build has errored
         */

        public static string PENDING = "Pending";
        public static string PASSED = "Passed";
        public static string FIXED = "Fixed";
        public static string BROKEN = "Broken";
        public static string FAILED = "Failed";
        public static string STILL_FAILING = "Still Failing";
        public static string CANCELED = "Canceled";
        public static string ERRORED = "Errored";
    }
}
