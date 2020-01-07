//生徒一人のデータを格納するStudentクラス
class Student {


    private int student_num; //学籍番号
    private String name; //氏名


    //Studentコンストラクタ
    Student (int num , String name ) {
        this.student_num = num; //引数numを学籍番号に代入
        this.name = name; //引数nameを氏名に代入
    }
    
    public void set_name (String name) {
        this.name = name;
    }

    public void set_num (String name) {
        return this.name;
    }

    public String get_name () {
        return this.name;
    }

    public int get_num () {
        return this.num;
    }


    //学籍番号、氏名を表示する関数print
    public void print () {
        System.out.println( "学籍番号:" + student_num ); //学籍番号出力
        System.out.println( "氏名:" + name+"\n" ); //氏名出力
    }




}
