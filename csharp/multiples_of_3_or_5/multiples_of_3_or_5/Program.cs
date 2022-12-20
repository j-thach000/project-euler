/* TODO:
 * [x] variable holding sum (can't access sum variable inside loop due to scope)
 * [x] loop iterating through the numbers [1, 1000)
 * [x] print sum
 */

using Internal;

int sum = 0;
for (int i = 1; i < 1000; i++)
{
    if (i % 3 == 0 || i % 5 == 0) sum += i;
}
Console.WriteLine(sum);
