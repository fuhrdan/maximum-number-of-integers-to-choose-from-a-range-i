//*****************************************************************************
//** 2554. Maximum Numbers of Integers to Choose From a Range I    leetcode  **
//*****************************************************************************

bool* createHashSet(int* banned, int bannedSize, int maxNum)
{
    bool* hashSet = (bool*)calloc(maxNum + 1, sizeof(bool));
    for (int i = 0; i < bannedSize; i++)
    {
        if (banned[i] <= maxNum) 
        {
            hashSet[banned[i]] = true;
        }
    }
    return hashSet;
}

int maxCount(int* banned, int bannedSize, int n, int maxSum)
{
    bool* hashSet = createHashSet(banned, bannedSize, n);

    int count = 0;
    int sum = 0;

    for (int i = 1; i <= n; i++)
    {
        if (hashSet[i]) 
        {
            continue;
        }

        sum += i;

        if (sum > maxSum) 
        {
            free(hashSet); 
            return count;
        }

        count++;
    }

    free(hashSet);
    return count;
}