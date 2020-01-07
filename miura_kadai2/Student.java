//生徒一人のデータを格納するStudentクラス
public class Student {


    private int student_num;//学籍番号
    private String name;//氏名


    //Studentコンストラクタ
    Student(int num, String name) {
        student_num = num;//引数numを学籍番号に代入
        this.name = name;//引数nameを氏名に代入
    }

    //学籍番号、氏名を表示する関数print
    public void print() {
        System.out.println("学籍番号:" + student_num);//学籍番号出力
        System.out.println("氏名:" + name+"\n");//氏名出力
    }


    public static void main(String[] args) {

        //Student型の配列students
        Student[] students = new Student[] {
                new Student(1,"太郎"),//太郎初期化
                new Student(2,"花子"),//花子初期化
                new Student(3,"道子"),//道子初期化
                new Student(4,"次郎"),//次郎初期化
                new Student(5,"蓮華")//蓮華初期化
        };

        for(Student s: students)//拡張for文で、生徒人数分のデータを出力する
        {
           s.print();//生徒のデータを出力する
        }
    }

}
