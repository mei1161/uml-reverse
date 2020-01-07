class Main{
    public static void main( String[] args ) {

        //Student型の配列students
        Student[] students = new Student[] {
                new Student ( 1 , "太郎" ), //太郎初期化
                new Student ( 2 , "花子" ), //花子初期化
                new Student ( 3 , "道子" ), //道子初期化
                new Student ( 4 , "次郎" ), //次郎初期化
                new Student ( 5 , "蓮華" )  //蓮華初期化
        };

        for( Student s: students ) //拡張for文で、生徒人数分のデータを出力する
        {
           s.print(); //生徒のデータを出力する
        }
    }
}