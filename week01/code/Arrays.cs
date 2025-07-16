public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
       // Step 1: Create an array of type double with size equal to 'length'.
        // Step 2: Use a for loop to fill the array.
        // Step 3: For each index i (starting from 0), compute the value: number * (i + 1)
        // Step 4: Store this value in the array at position i.
        // Step 5: After the loop ends, return the array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Confirm that amount is between 1 and data.Count (it's guaranteed by instructions).
        // Step 2: Calculate how many items to move to the front → this is (data.Count - amount)
        // Step 3: Use GetRange to get the last 'amount' elements from the list.
        // Step 4: Use GetRange to get the first (data.Count - amount) elements.
        // Step 5: Clear the original list.
        // Step 6: Add the last part first (rotated to front), then add the first part after it.
        // This effectively rotates the list to the right by 'amount'.

        int count = data.Count;

        // Step 3
        List<int> lastPart = data.GetRange(count - amount, amount);

        // Step 4
        List<int> firstPart = data.GetRange(0, count - amount);

        // Step 5
        data.Clear();

        // Step 6
        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}
