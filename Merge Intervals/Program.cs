/**
 * Definition for an interval.
 * public class Interval {
 *     int start;
 *     int end;
 *     Interval() { start = 0; end = 0; }
 *     Interval(int s, int e) { start = s; end = e; }
 * }
 */

import java.lang.*;

public class Solution
{
    public ArrayList<Interval> insert(ArrayList<Interval> intervals, Interval newInterval)
    {
        ArrayList<Interval> result = new ArrayList<Interval>();

        if (intervals.size() == 0)
        {
            result.add(newInterval);

            return result;
        }
        
        for (int i = 0; i < intervals.size(); i++)
        {
            if (result.size() == 0)
            {
                ArrayList<Interval> mergeResult = merge(intervals.get(i), newInterval);
                result.addAll(mergeResult);
            }
            else
            {
                ArrayList<Interval> mergeResult = merge(intervals.get(i), result.get(result.size() - 1));
                result.remove(result.size() - 1);
                result.addAll(mergeResult);
            }
        }

        return result;
    }

    public ArrayList<Interval> merge(Interval first, Interval second)
    {
        ArrayList<Interval> result = new ArrayList<Interval>();

        if (first.end < second.start)
        {
            result.add(first);
            result.add(second);
            return result;
        }
        else if (first.end == second.start)
        {
            Interval newInterval = 
		new Interval(Math.min(first.start,second.start),Math.max(first.start,second.start));
            result.add(newInterval);
            return result;
        }
        else
        {
            if (first.start > second.end)
            {
                result.add(second);
                result.add(first);
                return result;
            }
            else
            {
                Interval newInterval = 
			new Interval(Math.min(first.start,second.start),Math.max(first.end,second.end));
                result.add(newInterval);
                return result;
            }
        }
    }
}