/*
*********************************************************************************************************
*                                             FUNCTIONS FILE
*********************************************************************************************************
*/

#include<DAVE.h>                    //Declarations from DAVE Code Generation (includes SFR declaration)
#include<probe_scope.h>
#include<math.h>
#include<stdlib.h>
#include<definitions.h>


/*Looks for the Short Circuit phase*/
int ShortCircuitIdent(float* SumI){

	float	CurrentSum=0,PercentIA,PercentIB,PercentIC;
	int SCPHASE;

	CurrentSum=SumI[0]+SumI[1]+SumI[2];
	PercentIA=SumI[0]/CurrentSum;
	PercentIB=SumI[1]/CurrentSum;
	PercentIC=SumI[2]/CurrentSum;
	if((PercentIA>PercentIB)&&(PercentIA>PercentIC)){SCPHASE=1;}
	if((PercentIB>PercentIA)&&(PercentIB>PercentIC)){SCPHASE=2;}
	if((PercentIC>PercentIA)&&(PercentIC>PercentIB)){SCPHASE=3;}

	return SCPHASE;
}

/*Groups the bins around a frequency*/
float BinGroupUp(float* MagVector,int ArrayPosition){

	float Mag=0;
	int k=1;
	Mag=MagVector[ArrayPosition];
	while(k<=BINGROUP){
		Mag=Mag+MagVector[ArrayPosition-k]+MagVector[ArrayPosition+k];
		k++;
	}
	return Mag;
}

/*Analyses the FFT of the Motor current in order to obtain BRBMag*/
void MotorSignalAnalysis(float* MagVector,float* FsMag,float* BRBMag,float* fsfreq,float* brbfreq){

	float Freq,up,down;
	float BinFreq=(float)(SAMPLINGFREQ)/FFTSIZE;

	for(int j=1;j<(FFTSIZE/2);j++){//Starts in bin 1 because bin 0 is the DC offset
		Freq=(float)(j)*BinFreq;

		if((Freq>= MOTORSFREQ) && (Freq<(MOTORSFREQ+BinFreq))){
			up= fabs(MOTORSFREQ-((float)(j)*BinFreq));
			down= fabs(MOTORSFREQ-((float)(j-1)*BinFreq));
			if(up<=down){
				*fsfreq=Freq;
				*FsMag=BinGroupUp(MagVector,j);
			}
			if(down<up){
				*fsfreq=Freq-BinFreq;
				*FsMag=BinGroupUp(MagVector,(j-1));
			}
			}
		if((Freq>= FREQBRB) && (Freq<(FREQBRB+BinFreq))){
			up= fabs(FREQBRB-((float)(j)*BinFreq));
			down= fabs(FREQBRB-((float)(j-1)*BinFreq));
			if(up<=down){
				*brbfreq=Freq;
				*BRBMag=BinGroupUp(MagVector,j);
			}
			if(down<up){
				*brbfreq=(j-1)*BinFreq;
				*BRBMag=BinGroupUp(MagVector,(j-1));
			}
			}
	}


}

/* Does the EPVA Analysis in order to obtain FFTPARKavg and SCMag*/
float EPVAAnalysis(float* MagVector,float* SCMag,float*SCSeverity,float*SCBinFreq){

	float Freq, up,down;
	float BinFreq=(float)(SAMPLINGFREQ)/FFTSIZE;
	float FFTPARKavg=0;

	for(int j=1;j<(FFTSIZE/2);j++){//Starts in bin 1 because bin 0 is the DC offset
		FFTPARKavg=FFTPARKavg+MagVector[j];

		Freq=(float)(j)*BinFreq;

		if((Freq>= (2*MOTORSFREQ)) && (Freq<((2*MOTORSFREQ)+BinFreq))){
			up= fabs((2*MOTORSFREQ)-((float)(j)*BinFreq));
			down= fabs((2*MOTORSFREQ)-((float)(j-1)*BinFreq));
			if(up<=down){
				*SCBinFreq=Freq;
				*SCMag=BinGroupUp(MagVector,j);
			}
			if(down<up){
				*SCBinFreq=Freq-BinFreq;
				*SCMag=BinGroupUp(MagVector,(j-1));
			}
		}
	}

	FFTPARKavg=FFTPARKavg/((FFTSIZE/2)-1);
	*SCSeverity=*SCMag/MagVector[0];
	return FFTPARKavg;

}


void ResultAnalysis(float FFTPARKavg,float SCMag,float magzeroEPVA ,float BRBMag, float* SumI, float* RA, int* ERRORPRESENT){

	RA[0]=FFTPARKavg;
	if(RA[0]>FFTEPVALIMIT){ERRORPRESENT[0]=1;} else{ERRORPRESENT[0]=0;}

	RA[1]=SCMag;
	if(RA[1]>SCLIMIT){
		ERRORPRESENT[1]=1;
		ERRORPRESENT[2]=ShortCircuitIdent(SumI);
		RA[2]=SCMag/magzeroEPVA;
	}
	else{
		ERRORPRESENT[1]=0;
		ERRORPRESENT[2]=0;
		RA[2]=0;
	}

	RA[3]=BRBMag;
	if(RA[3]>BRBLIMIT){ERRORPRESENT[3]=1;} else{ERRORPRESENT[3]=0;}


}
