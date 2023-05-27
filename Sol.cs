
//-------------1------------//
public static int IsBig(int []arr,int x,int y)
{
	int count=0;
	
	for(int i=0;i<arr.Length;i++)
	{
		if(arr[i]>y && arr[i] <x)
			count++;
	}
	return count;
}

//-------------2------------//

//أ
public int Compare(Lecture other)
{
	if (this.subject==other.subject&&this.place!=other.place);
	        return 1;
		if (this.subject!=other.subject&&this.place==other.place);
	        return 2;	
		return 0;
}

//ب

public static int CountLecture(Lecture[]arr,string place)
{
	int count=0;
	
	for(int i=0;i<arr.Length;i++)
	{
		if(arr[i].GetPlace()==place)
			count++;
	}
	return count;
}

//ج
public static string MaxDuration(Lecture arr)
{
	int iMax=arr[0].GetDuration();
	string max=arr[0].GetSubject();
	
	for(int i=1;i<arr.Length;i++)
	{
		if(arr[i].GetDuration()>iMax)
		{
			iMax=arr[i].GetDuration();
			max=arr[i].GetSubject()
			
		}
	}
	return max;
}
	
//-------------3------------//
//أ
public Engineer(string name,int seniority,int Degree)
{
 this.name=name;
 this.seniority=seniority;
 this.Degree=Degree; 
}
//ب
//1
  public class Company{
	  public static int maxSize=120;
	  private string CompanyName;
	  private Engineer[]arEng;
	  private int current;

//2
   public void AddEngineer(Engineer engineer)
   {
	   this.arEng[this.current]=engineer;
	   this.current++;
   }
 
 //3
   public int Count(int deg)
   {
	   int count=0;
	   for(int i=0;i<this.current;i++)
	   {
		   if(this.arEng[i].GetDegree()==deg)
			   count++;
	   }
	   return count;
   }
 //4
     public string MaxSeniority()
	 {
       int imax=this.arEng[0].GetSeniority();
	   string name=this.arEng[0].GetName();
	   
	   
       for(int i=1;i<this.current;i++)
	   {
		   if(this.arEng[i].GetSeniority()>imax)
		   {
			   imax=this.arEng[i].GetSeniority();
			   name=this.arEng[i].GetName();
		   }
	   }

           return name;	   
	 }
	 
	
	 
	 
	 
	 //--------------5-----------------//
	 //أ
        public static string Place(Node<MyWord>lst, int k)
        {
            Node<MyWord> pos = lst;

            while (pos != null)
            {
                if (pos.GetValue().getPlace() == k)
                    return pos.GetValue().GetWord();
                pos = pos.GetNext();
            }
            return "";
        }
	 
	 //ب
	 string st="";
	 int place=1;
	 Node<MyWord>temp=lst1;
	 while(temp!=null)
	 {
		 st+=Place(temp,place);
		 place++;
		 temp=temp.GetNext();
	 }
	 Console.WriteLine(st);
	 
	 
	 //------------------6-------------//
	 
	 public static Queue<int> MiddleQueue(Queue<int>q,int m)
	 {
		 Queue<int>newQ=new Queue<int>();
		 Queue<int>temp=new Queue<int>();
		 int x=(Size(q)-m)/2;
		 int num=1;
		 while(num<=x){
			 temp.Insert(q.Remove());
			 num++;
		 }
		 num=0;
		 
		 while(num<m)
		 { 
	       num++
	       newQ.Insert(q.Head());
		   temp.Insert(q.Remove());
		 }
		
		 while(!q.IsEmpty())
			  temp.Insert(q.Remove());
		 
		  while(!temp.IsEmpty())
			  q.Insert(temp.Remove());
		 
		 return newQ;
		 
	 }
	 //פעולת עזר-عملية مساعدة تعيد كبر الدور
	 public static int Size(Queue<int>q)
	 {
		 int count=0;
		 while(!q.IsEmpty())
		 {
			 count++;
			 q.Remove();
		 }
		 return count;
	 }
	 
	 
	 
	 
	 

//-------------7------------//
//أ
        public static bool IswhiteBlack(BinNode<char> t)
        {
            if (t == null)
                return true;
			
			if(t.GetValue()!='w' || t.GetValue()!='b')
			    return false;
			
			
            if (t.HasLeft() && t.GetLeft().GetValue() != 'w' || t.HasRight() && t.GetRight().GetValue() != 'b')
                return false;
            return IswhiteBlack(t.GetLeft()) && IswhiteBlack(t.GetRight());
        }


        //ب
  //لا حاجة لفحص اذا كانت الشجرة هي شجرة بيضاء سوداء لانه حسب البند ب العملية تتلقى شجرة بيضاء سوداء اي انها معطاة في السؤال
        public static int Diff(BinNode<char> t)
        {
            return CountWhite(t) - CountBlack(t);
        }
        public static int CountWhite(BinNode<char> t)
        {
            if (t == null)
                return 0;
            if (t.GetLeft().GetValue() == 'w')
                return 1 + CountBlack(t.GetLeft()) + CountBlack(t.GetRight());
            return CountBlack(t.GetLeft()) + CountBlack(t.GetRight());

        }
        public static int CountBlack(BinNode<char> t)
        {
            if (t == null)
                return 0;
            if (t.GetRight().GetValue() == 'b')
                return 1 + CountBlack(t.GetLeft()) + CountBlack(t.GetRight());
            return CountBlack(t.GetLeft()) + CountBlack(t.GetRight());
        }

































