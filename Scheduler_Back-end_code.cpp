#include <algorithm>
#include <bitset>
#include <complex>
#include <deque>
#include <exception>
#include <fstream>
#include <functional>
#include <iomanip>
#include <ios>
#include <iosfwd>
#include <iostream>
#include <istream>
#include <iterator>
#include <limits>
#include <list>
#include <locale>
#include <map>
#include <memory>
#include <new>
#include <numeric>
#include <ostream>
#include <queue>
#include <set>
#include <sstream>
#include <stack>
#include <stdexcept>
#include <streambuf>
#include <string>
#include <typeinfo>
#include <utility>
#include <valarray>
#include <vector>

using namespace std;
double current_time;
double total_wt = 0;
double total_ta = 0;
std::ofstream ofs("sched_out", std::ofstream::out);
vector<double> split(string str) {
	vector<double> arguments;
	int aize = str.length();
	string temp;
	for (int i = 0; i <= str.length(); i++) {
		if (i == str.length()) {
			arguments.push_back(stof(temp));
			break;
		}
		if (str[i] == ' ') {
			arguments.push_back(stof(temp));
			temp = "";
		}
		else {
			temp += str[i];
		}
	}
	return arguments;
}
class process
{
public:
	int p_id;
	double arriv_time;
	double req_time;
	double real_req_time;
	int priority;
	double ct;
	double wt;
	double ta;
	double rt;
	process(double id, double arriv_t, double req_t, double pr = 1)
	{
		p_id = id;
		arriv_time = arriv_t;
		req_time = req_t;
		real_req_time = req_t;
		priority = pr;
	}
};
void add_process(vector<process>& process_list, vector<double> arguments)
{
	for (int i = 0; i < arguments[3]; i++) {
		process new_p = process((i + 1), arguments[i + 4], arguments[i + 4 + arguments[3]], arguments[i + 4 + (2 * arguments[3])]);
		process_list.push_back(new_p);
	}

}
bool arrive_first(process p1, process p2) { return (p1.arriv_time < p2.arriv_time); } //fcfs
bool compare_sjf_prem(process p1, process p2) { return (p1.req_time < p2.req_time); }
bool compare_sjf_non(process a, process b)        //sjf non prem 
{
	return a.req_time < b.req_time && a.arriv_time <= current_time;
	/* This process will always return TRUE
	if above condition comes*/
}
bool compare_prio_non(process a, process b)  //priority non prem
{
	return a.priority < b.priority && a.arriv_time <= current_time;
	/* This process will always return TRUE
	if above condition comes*/
}
bool compare_prio_prem(process a, process b) {
	return(a.priority < b.priority);
}
double total_time(vector<process> pros_list)
{
	double t = 0;
	for (int i = 0; i < pros_list.size(); i++)
		t += pros_list[i].req_time;
	return t;
}
void FCFS(vector<process> p_list) {
	sort(p_list.begin(), p_list.end(), arrive_first);
	p_list[0].ct = p_list[0].req_time + p_list[0].arriv_time;
	p_list[0].ta = p_list[0].ct - p_list[0].arriv_time;
	p_list[0].wt = p_list[0].ta - p_list[0].req_time;
	ofs << "p" << p_list[0].p_id << ":" << p_list[0].arriv_time << " " << p_list[0].ct << endl;
	current_time = p_list[0].ct;
	int i = 1;
	while (i < p_list.size()) {
		if (p_list[i].arriv_time > p_list[i - 1].ct) {
			p_list[i - 1].ct = p_list[i].arriv_time;
		}

		p_list[i].ct = p_list[i].req_time + p_list[i - 1].ct;
		p_list[i].ta = p_list[i].ct - p_list[i].arriv_time;
		p_list[i].wt = p_list[i].ta - p_list[i].req_time;
		ofs << "p" << p_list[i].p_id << ":" << p_list[i - 1].ct << " " << p_list[i].ct << endl;
		i++;
	}
	for (int i = 0; i < p_list.size(); i++) {
		total_ta += p_list[i].ta;
		total_wt += p_list[i].wt;
	}
	ofs << "& " << total_wt / p_list.size() << endl;
	ofs << "% " << total_ta / p_list.size() << endl;
}
void prio_non(vector<process> p_list) {

	sort(p_list.begin(), p_list.end(), compare_prio_non);
	if (p_list[0].arriv_time == p_list[p_list.size() - 1].arriv_time) {

	}
	p_list[0].ct = p_list[0].req_time + p_list[0].arriv_time;
	p_list[0].ta = p_list[0].ct - p_list[0].arriv_time;
	p_list[0].wt = p_list[0].ta - p_list[0].req_time;
	ofs << "p" << p_list[0].p_id << ":" << p_list[0].arriv_time << " " << p_list[0].ct << endl;
	current_time = p_list[0].ct;
	for (int i = 1; i < p_list.size(); i++)
	{
		current_time = p_list[i - 1].ct;
		sort(p_list.begin() + i, p_list.end(), compare_prio_non);
		//gap corner case
		if (p_list[i - 1].ct < p_list[i].arriv_time)
		{
			p_list[i - 1].ct = p_list[i].arriv_time;
		}

		p_list[i].ct = p_list[i - 1].ct + p_list[i].req_time;
		p_list[i].ta = p_list[i].ct - p_list[i].arriv_time;
		p_list[i].wt = p_list[i].ta - p_list[i].req_time;
		ofs << "p" << p_list[i].p_id << ":" << p_list[i - 1].ct << " " << p_list[i].ct << endl;
	}
	for (int i = 0; i < p_list.size(); i++) {
		total_ta += p_list[i].ta;
		total_wt += p_list[i].wt;
	}
	ofs << "& " << total_wt / p_list.size() << endl;
	ofs << "% " << total_ta / p_list.size() << endl;
}
void sjf_non(vector<process> p_list) {
	sort(p_list.begin(), p_list.end(), compare_sjf_non);
	p_list[0].ct = p_list[0].req_time + p_list[0].arriv_time;
	p_list[0].ta = p_list[0].ct - p_list[0].arriv_time;
	p_list[0].wt = p_list[0].ta - p_list[0].req_time;
	ofs << "p" << p_list[0].p_id << ":" << p_list[0].arriv_time << " " << p_list[0].ct << endl;
	current_time = p_list[0].ct;
	for (int i = 1; i < p_list.size(); i++)
	{
		current_time = p_list[i - 1].ct;
		sort(p_list.begin() + i, p_list.end(), compare_sjf_non);
		//gap corner case
		if (p_list[i - 1].ct < p_list[i].arriv_time)
		{
			p_list[i - 1].ct = p_list[i].arriv_time;
		}

		p_list[i].ct = p_list[i - 1].ct + p_list[i].req_time;
		p_list[i].ta = p_list[i].ct - p_list[i].arriv_time;
		p_list[i].wt = p_list[i].ta - p_list[i].req_time;
		ofs << "p" << p_list[i].p_id << ":" << p_list[i - 1].ct << " " << p_list[i].ct << endl;
	}
	for (int i = 0; i < p_list.size(); i++) {
		total_ta += p_list[i].ta;
		total_wt += p_list[i].wt;
	}
	ofs << "& " << total_wt / p_list.size() << endl;
	ofs << "% " << total_ta / p_list.size() << endl;
}
bool find_in_deq(deque<process> w, process p) {
	int indicator = 0;
	for (int i = 0; i < w.size(); i++) {
		if (w[i].p_id == p.p_id) {
			return false;
			break;
		}
		else {
			indicator++;
		}
	}
	if (indicator == w.size()) {
		return true;
	}

}
deque<process> arrange(vector<process> p, double ct, deque<process> w, int size) {
	deque<process> w_t = w;
	for (int i = 0; i < size; i++)
	{
		if (p[i].arriv_time <= ct) {
			if (find_in_deq(w_t, p[i])) {
				w_t.push_back(p[i]);
			}
		}
	}
	return w_t;
}  //roundrobin
int return_addr(int pos, vector<process>p, int size) {
	for (int i = 0; i < size; i++) {
		if (pos == p[i].p_id) {
			return i;
		}
	}
}
void RR(vector<process> p_list, double step)
{
	double orig_size = p_list.size(); // var to store the size of p_list before any modifictaion
	vector <process> original = p_list;
	vector<double> waiting_time; //vector to save the waiting time and turn.around time of each process 
	vector < double > turn_time;
	int size = p_list.size(); //size of process which i can modify
	double tt = total_time(p_list); //total time of process in order to continue looping until they are all done 
	bool flag = true;
	deque<process> working; //request queue process
	double ta_t = 0; //var to store turn. time and waiting time in every last iteration of the process
	double w_t = 0;
	double ot = 0; //old time before the current time being modified
	int pos = 0;  // var to be used to return the position of the process to access it p_id and other
	sort(p_list.begin(), p_list.end(), arrive_first);
	if (p_list[0].req_time <= step) {
		ot = p_list[0].arriv_time;
		current_time += p_list[0].req_time;
		ta_t = current_time - ot; //turning around time
		turn_time.push_back(ta_t);
		w_t = ta_t - p_list[0].req_time; //waitning around time
		waiting_time.push_back(w_t);
		ofs << "p" << p_list[0].p_id << ":" << ot << " " << current_time << endl;
		tt -= p_list[0].req_time;
		p_list.erase(p_list.begin());
		size--;
	}
	else {
		ot = p_list[0].arriv_time;
		current_time = p_list[0].arriv_time + step;
		ofs << "p" << p_list[0].p_id << ":" << p_list[0].arriv_time << " " << current_time << endl;
		p_list[0].req_time -= step;
		working.push_back(p_list[0]);
		tt -= step;
	}
	while (p_list.size() != 0) {
		working = arrange(p_list, current_time, working, size);
		if (working.empty() == true) {
			for (int i = 0; i < p_list.size(); i++) {
				if (current_time > p_list[i].arriv_time) {}
				else {
					current_time = p_list[i].arriv_time;
					break;
				}
			}
		}
		working = arrange(p_list, current_time, working, size);
		if (flag == true && working.size() != 0)
		{
			working.push_back(p_list[0]);
			working.pop_front();
			flag = false;
		}
		while (!working.empty()) {
			int pos = working.front().p_id;
			int n = return_addr(pos, p_list, size);
			int addr = return_addr(pos, original, orig_size);
			if (working.front().req_time <= step) {
				ot = current_time;
				current_time += working.front().req_time;
				ofs << "p" << working.front().p_id << ":" << ot << " " << current_time << endl;
				ta_t = current_time - original[addr].arriv_time; //turning around time
				w_t = ta_t - original[addr].req_time;
				turn_time.push_back(ta_t); //waitning around time
				waiting_time.push_back(w_t);
				tt -= working.front().req_time;
				working.pop_front();
				p_list.erase(p_list.begin() + n);
				size--;
			}
			else {
				ot = current_time;
				current_time += step;
				ofs << "p" << pos << ":" << ot << " " << current_time << endl;
				p_list[n].req_time -= step;
				working.front().req_time -= step;
				working = arrange(p_list, current_time, working, size);
				if (working.size() == 1) {}
				else {
					working.push_back(working[0]);
					working.pop_front();
				}
				tt -= step;
			}
		}
	}
	for (int i = 0; i < orig_size; i++) {
		total_wt += waiting_time[i];
		total_ta += turn_time[i];
	}
	ofs << "& " << total_wt / orig_size << endl;
	ofs << "% " << total_ta / orig_size << endl;
}
double next_arrivaltime(vector<process> pros_list)
{
	if (pros_list.size() == 0) {}
	else {
		double min = pros_list[0].arriv_time;
		for (int i = 0; i < pros_list.size(); i++)
		{
			if (min > pros_list[i].arriv_time)
				min = pros_list[i].arriv_time;
		}
		return min;
	}
}
double next_sjf(double time, vector<process> pros_list)
{
	if (pros_list.size() == 0) {}
	else {
		for (int i = 0; i < pros_list.size(); i++)
		{
			if (time > pros_list[i].req_time)
				return pros_list[i].arriv_time;
		}
	}
	return -1;
}
void sjf_pre(vector<process> p_list) {
	double size = p_list.size();
	double tt = total_time(p_list);
	double next_step;
	bool flag;
	vector<double> wait_time;
	vector<double> turn_time;
	vector<process> working;
	vector<process> original = p_list;
	sort(p_list.begin(), p_list.end(), arrive_first);
	while (original.size() != 0) {
		flag = 1;
		for (int i = 0; i < p_list.size(); i++) {
			if (p_list[i].arriv_time <= current_time)
			{
				working.push_back(p_list[i]);
				sort(working.begin(), working.end(), compare_sjf_prem);
				p_list.erase(p_list.begin() + i);
				i--;
			}
		}
		if (working.size() != 0)
		{

			next_step = next_sjf(working[0].real_req_time, p_list);
			flag = 0;
			ofs << "p" << working[0].p_id << ":" << current_time;
			if (next_step > 0)
			{
				if (next_step < (working[0].req_time + current_time))
				{
					tt -= (next_step - current_time);
					working[0].req_time -= (next_step - current_time);
					current_time = next_step;
				}
				else
				{
					tt -= working[0].req_time;
					current_time += working[0].req_time;
					working[0].req_time = 0;

				}
			}
			if (next_step == -1)
			{
				tt -= working[0].req_time;

				current_time += working[0].req_time;

				working[0].req_time = 0;
			}
			ofs << " " << current_time << endl;
			double tat;
			double awt;
			if (working[0].req_time <= 0) {
				tat = current_time - working[0].arriv_time;
				awt = tat - working[0].real_req_time;
				turn_time.push_back(tat);
				wait_time.push_back(awt);
				working.erase(working.begin());
				original.erase(original.begin());
			}
		}
		if (flag == 1)
		{
			current_time = next_arrivaltime(p_list);
		}
	}
	for (int i = 0; i < size; i++) {
		total_ta += turn_time[i];
		total_wt += wait_time[i];
	}

	ofs << "& " << total_wt / size << endl;
	ofs << "% " << total_ta / size << endl;
}
double next_priority(int priority, vector<process> pros_list) {
	if (pros_list.size() == 0) {}
	else {
		for (int i = 0; i < pros_list.size(); i++)
		{
			if (priority > pros_list[i].priority)
				return pros_list[i].arriv_time;
		}
	}
	return -1;
}
void prio_prem(vector<process>p_list) {
	double size = p_list.size();
	double tt = total_time(p_list);
	double next_step;
	bool flag;
	vector<double> wait_time;
	vector<double> turn_time;
	vector<process> working;
	vector<process> original = p_list;
	sort(p_list.begin(), p_list.end(), arrive_first);
	while (original.size() != 0) {
		flag = 1;
		for (int i = 0; i < p_list.size(); i++)
		{
			if (p_list[i].arriv_time <= current_time)
			{
				working.push_back(p_list[i]);
				sort(working.begin(), working.end(), compare_prio_prem);
				p_list.erase(p_list.begin() + i);
				i--;
			}
		}
		if (working.size() != 0)
		{
			next_step = next_priority(working[0].priority, p_list);
			flag = 0;
			ofs << "p" << working[0].p_id << ":" << current_time;
			if (next_step > 0)
			{
				if (next_step < (working[0].req_time + current_time))
				{
					tt -= (next_step - current_time);
					working[0].req_time -= (next_step - current_time);
					current_time = next_step;
				}
				else
				{
					tt -= working[0].req_time;

					current_time += working[0].req_time;
					working[0].req_time = 0;

				}
			}
			if (next_step == -1)
			{
				tt -= working[0].req_time;
				current_time += working[0].req_time;
				working[0].req_time = 0;
			}
			ofs << " " << current_time << endl;
			double tat;
			double awt;
			if (working[0].req_time <= 0) {
				tat = current_time - working[0].arriv_time;
				awt = tat - working[0].real_req_time;
				turn_time.push_back(tat);
				wait_time.push_back(awt);
				working.erase(working.begin());
				original.erase(original.begin());
			}
		}
		if (flag == 1)
		{
			current_time = next_arrivaltime(p_list);
		}
	}

	for (int i = 0; i < size; i++) {

		total_ta += turn_time[i];
		total_wt += wait_time[i];
	}

	ofs << "& " << total_wt / size << endl;
	ofs << "% " << total_ta / size << endl;
}

int main(int argc, char*argv[])
{
	vector<double> arguments = split(argv[1]);
	vector<process> p_list;
	add_process(p_list, arguments);
	if (arguments[0] == 1) {
		FCFS(p_list);
	}
	if (arguments[0] == 3 && arguments[1] == 0) {
		prio_non(p_list);
	}
	else if (arguments[0] == 2 && arguments[1] == 0) {
		sjf_non(p_list);
	}
	else if (arguments[0] == 4) {
		double step = arguments[2];
		RR(p_list, step);
	}
	else if (arguments[0] == 2 && arguments[1] == 1) {
		sjf_pre(p_list);
	}
	else if (arguments[0] == 3 && arguments[1] == 1) {
		prio_prem(p_list);
	}
}