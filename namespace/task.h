
namespace ElektroShop {

	class Product {
	private:
		string name;
		string pratuqMadel;
		int price;
		int id;
	public:
		Product() {
			name=" ";
			pratuqMadel=" ";
			price=0;
			id=0;
		}
		Product(string name, string pratuqMadel, int price) {
			setName(name);
			setPratuqMadel(pratuqMadel);
			setPrice(price);
			setId(id);
		}
		void setName(string name) {
			this->name = name;
		}
		void setPratuqMadel(string pratuqMadel) {
			this->pratuqMadel = pratuqMadel;
		}
		void setPrice(int price) {
			this->price = price;
		}
		void setId(int id) {
			this->id = id;
		}

		string getName() {
			return name;
		}
		string getPratuqMadel() {
			return pratuqMadel;
		}
		int getPrice() {
			return price;
		}
		int getId() {
			return id;
		}
		void showPradukt() {
			cout << "Pradukt name : " << name << endl <<
				"Pradukt PratuqMadel : " << pratuqMadel << endl <<
				"Pradukt Price : " << price << endl <<
				"Pradukt Id : " << id << endl;
		}
		~Product() {};
	};


	class Guest :Product {
		string fulName;
		~Guest() {};
	};

	class Admin : public Product {
		string userName;
		int pasword;
	public:
		Admin(string userName, int pasword, string name, string pratuqMadel, int price) :
			Product(name,pratuqMadel,price){
			setUserName(userName);
			setPasvord(pasword);
		}
		void setUserName(string userName) {
			this->userName = userName;
		}
		void setPasvord(int pasword) {
			this->pasword = pasword;
		}
		string getuserName() {
			return userName;
		}
		int getPasword() {
			return pasword;
		}

		~Admin() {};
	};


	class Databaze {
		static vector<Product> p1;
		static vector<Admin> a1;
		static vector<Guest> g1;
	public:
		void showAllProdukt() {
			for (int i = 0; i < p1.size(); i++)
			{
				p1.front().showPradukt();
				p1.pop_back();
			}
		}
		void addPradukt() {
			Product p2;
			string nname;
			string ppratuqMadel;
			int pprice;
			int iid;
			cout << "Nameni daxil edin : ";
			cin >> nname;
			cout << "PratuqMadel daxil edin : ";
			cin >> ppratuqMadel;
			cout << "Price daxil edin : ";
			cin >> pprice;
			cout << "Id daxil edin : ";
			cin >> iid;
			p2.setName(nname);
			p2.setPratuqMadel(ppratuqMadel);
			p2.setPrice(pprice);
			p2.setId(iid);
			p1.push_back(p2);
		}
		void deletePradukt() {

		}
		void udaptePratukt() {

		}

	};







}
