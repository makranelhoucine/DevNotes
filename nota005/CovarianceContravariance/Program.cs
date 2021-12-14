IReader<A> readerA = new Reader<A>();
IReader<B> readerB = new Reader<B>();
IReader<C> readerC = new Reader<C>();
IWriter<A> writerA = new Writer<A>();
IWriter<B> writerB = new Writer<B>();
IWriter<C> writerC = new Writer<C>();
IReaderWriterInvariant<A> readerWriterA = new ReaderWriterInvariant<A>();
IReaderWriterInvariant<B> readerWriterB = new ReaderWriterInvariant<B>();
IReaderWriterInvariant<C> readerWriterC = new ReaderWriterInvariant<C>();

#region Covariance
// IReader<TEntity> is Covariant, this means that:
// 1. All members either don't deal with TEntity or have it in the return type, not the input parameters
// 2. In a call, IReader<TEntity> could be replaced by any IReader<TAnotherEntity> given that TAnotherEntity
// is a child -directly or indirectly- of TEntity

// TestReader(readerB) is ok because TestReader is already expecting IReader<B>
System.Console.WriteLine("\nTest Reader B");
TestReader(readerB);

// TestReader(readerC) is ok because C is a child of B
System.Console.WriteLine("\nTest Reader C");
TestReader(readerC);

// TestReader(readerA) is NOT ok because A is a not a child of B
//TestReader(readerA);
#endregion

#region Contravariance
// IWriter<TEntity> is Contravariant, this means that:
// 1. All members either don't deal with TEntity or have it in the input parameters, not in the return type
// 2. In a call, IWriter<TEntity> could be replaced by any IWriter<TAnotherEntity> given that TAnotherEntity
// is a parent -directly or indirectly- of TEntity

// TestWriter(writerB) is ok because TestWriter is already expecting IWriter<B>
System.Console.WriteLine("\nTest Witer B");
TestWriter(writerB);

// TestWriter(writerA) is ok because A is a parent of B
System.Console.WriteLine("\nTest Reader A");
TestWriter(writerA);

// TestWriter(writerC) is NOT ok because C is a not a parent of B
//TestWriter(writerC);
#endregion

#region Invariance
// IReaderWriter<TEntity> is Invariant, this means that:
// 1. Some members have TEntity in the input parameters and others have TEntity in the return type
// 2. In a call, IReaderWriter<TEntity> could not be replaced by any IReaderWriter<TAnotherEntity>

// IReaderWriter(readerWriterB) is ok because TestReaderWriter is already expecting IReaderWriter<B>
System.Console.WriteLine("\nTest ReaderWriter B");
TestReaderWriter(readerWriterB);

// IReaderWriter(readerWriterA) is NOT ok because IReaderWriter<B> can not be replaced by IReaderWriter<A>
//TestReaderWriter(readerWriterA);

// IReaderWriter(readerWriterC) is NOT ok because IReaderWriter<B> can not be replaced by IReaderWriter<C>
//TestReaderWriter(readerWriterC);
#endregion


static void TestReader(IReader<B> param)
{
    System.Console.WriteLine("param: " + param.GetType().ToString());
    var b = param.Read();
    System.Console.WriteLine("b: " + b.GetType().ToString());
    b.F1();
    b.F2();
}

static void TestWriter(IWriter<B> param)
{
    System.Console.WriteLine("param: " + param.GetType().ToString());
    var b = new B();
    System.Console.WriteLine("b: " + b.GetType().ToString());
    param.Write(b);
}

static void TestReaderWriter(IReaderWriterInvariant<B> param)
{
    System.Console.WriteLine("param: " + param.GetType().ToString());
    var b = param.Read();
    System.Console.WriteLine("b: " + b.GetType().ToString());
    b.F1();
    b.F2();

    param.Write(b);
}