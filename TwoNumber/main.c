//problem url --> https://www.codechef.com/problems/TWONMS
#include <stdio.h>
#include <stdlib.h>


long long int max (long long int a,long long int b){
	return a>b?a:b;
}
long long int min (long long int a,long long int b){
	return a<b?a:b;
}

int main(){
	int test,i;
	scanf("%d",&test);
	for (i=0;i<test;i++){
		long long int a,b,n,val;
		scanf("%lld %lld %lld",&a,&b,&n);
		if (n%2==1){
			a=a*2;
			val=max(a,b)/min(a,b);
		}
		else
			val=max(a,b)/min(a,b);
		printf("%lld\n",val);

	}
	return 0;
}
