﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyPointManager : MonoBehaviour {


	//******add run button to move faster*****
	public Animator anim;
	public static int moneyPoints;
	public GameObject point;
	public GameObject point_1;
	public GameObject point_2;
	public GameObject point_3;
	public GameObject point_4;
	public GameObject point_5;
	public GameObject point_6;
	public GameObject point_7;
	public GameObject point_8;
	public GameObject point_9;
	public GameObject point_10;
	public GameObject point_11;
	public GameObject point_12;
	public GameObject point_13;
	public GameObject point_14;
	public GameObject point_15;
	public GameObject point_16;
	public GameObject point_17;

	public GameObject point_18;
	public GameObject point_19;
	public GameObject point_20;
	public GameObject point_21;
	public GameObject point_22;
	public GameObject point_23;
	public GameObject point_24;
	public GameObject point_25;
	public GameObject point_26;
	public GameObject point_27;
	public GameObject point_28;
	public GameObject point_29;
	public GameObject point_30;
	public GameObject point_31;
	public GameObject point_32;
	public GameObject point_33;
	public GameObject point_34;
	public GameObject point_35;
	public GameObject point_36;
	public GameObject point_37;
	public GameObject point_38;
	public GameObject point_39;
	public GameObject point_40;
	public GameObject point_41;

	void Start(){
		anim.SetBool ("full", false);
		point.SetActive (false);
		point_1.SetActive (false);
		point_2.SetActive (false);
		point_3.SetActive (false);
		point_4.SetActive (false);
		point_5.SetActive (false);
		point_6.SetActive (false);
		point_7.SetActive (false);
		point_8.SetActive (false);
		point_9.SetActive (false);
		point_10.SetActive (false);
		point_11.SetActive (false);
		point_12.SetActive (false);
		point_13.SetActive (false);
		point_14.SetActive (false);
		point_15.SetActive (false);
		point_16.SetActive (false);
		point_17.SetActive (false);
		point_18.SetActive (false);
		point_19.SetActive (false);
		point_20.SetActive (false);
		point_21.SetActive (false);
		point_22.SetActive (false);
		point_23.SetActive (false);
		point_24.SetActive (false);
		point_25.SetActive (false);
		point_26.SetActive (false);
		point_27.SetActive (false);
		point_28.SetActive (false);
		point_29.SetActive (false);
		point_30.SetActive (false);
		point_31.SetActive (false);
		point_32.SetActive (false);
		point_33.SetActive (false);
		point_34.SetActive (false);
		point_35.SetActive (false);
		point_36.SetActive (false);
		point_37.SetActive (false);
		point_38.SetActive (false);
		point_39.SetActive (false);
		point_40.SetActive (false);
		point_41.SetActive (false);
		moneyPoints = 0;
	}

	void FixedUpdate(){
		if(moneyPoints == 0){
			anim.SetBool ("full", false);
			point.SetActive (false);
			point_1.SetActive (false);
			point_2.SetActive (false);
			point_3.SetActive (false);
			point_4.SetActive (false);
			point_5.SetActive (false);
			point_6.SetActive (false);
			point_7.SetActive (false);
			point_8.SetActive (false);
			point_9.SetActive (false);
			point_10.SetActive (false);
			point_11.SetActive (false);
			point_12.SetActive (false);
			point_13.SetActive (false);
			point_14.SetActive (false);
			point_15.SetActive (false);
			point_16.SetActive (false);
			point_17.SetActive (false);
			point_18.SetActive (false);
			point_19.SetActive (false);
			point_20.SetActive (false);
			point_21.SetActive (false);
			point_22.SetActive (false);
			point_23.SetActive (false);
			point_24.SetActive (false);
			point_25.SetActive (false);
			point_26.SetActive (false);
			point_27.SetActive (false);
			point_28.SetActive (false);
			point_29.SetActive (false);
			point_30.SetActive (false);
			point_31.SetActive (false);
			point_32.SetActive (false);
			point_33.SetActive (false);
			point_34.SetActive (false);
			point_35.SetActive (false);
			point_36.SetActive (false);
			point_37.SetActive (false);
			point_38.SetActive (false);
			point_39.SetActive (false);
			point_40.SetActive (false);
			point_41.SetActive (false);
		}
		if(moneyPoints == 1){
			anim.SetBool ("full", false);
			point.SetActive (true);
		}
		if(moneyPoints == 2){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
		}
		if(moneyPoints == 3){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
		}
		if(moneyPoints == 4){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
		}
		if(moneyPoints == 5){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
		}
		if(moneyPoints == 6){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
		}
		if(moneyPoints == 7){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
		}
		if(moneyPoints == 8){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
		}
		if(moneyPoints == 9){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
		}
		if(moneyPoints == 10){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
		}
		if(moneyPoints == 11){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
		}
		if(moneyPoints == 12){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
		}
		if(moneyPoints == 13){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
		}
		if(moneyPoints == 14){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
		}
		if(moneyPoints == 15){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
		}
		if(moneyPoints == 16){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
		}
		if(moneyPoints == 17){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
		}
		if(moneyPoints == 18){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
		}
		if(moneyPoints == 19){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
		}
		if(moneyPoints == 20){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
		}
		if(moneyPoints == 21){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
		}
		if(moneyPoints == 22){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
		}
		if(moneyPoints == 23){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
		}
		if(moneyPoints == 24){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
		}
		if(moneyPoints == 25){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
		}
		if(moneyPoints == 26){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
		}
		if(moneyPoints == 27){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
		}
		if(moneyPoints == 28){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
		}
		if(moneyPoints == 29){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
			point_28.SetActive (true);
		}
		if(moneyPoints == 30){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
			point_28.SetActive (true);
			point_29.SetActive (true);
		}
		if(moneyPoints == 31){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
			point_28.SetActive (true);
			point_29.SetActive (true);
			point_30.SetActive (true);
		}
		if(moneyPoints == 32){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
			point_28.SetActive (true);
			point_29.SetActive (true);
			point_30.SetActive (true);
			point_31.SetActive (true);
		}
		if(moneyPoints == 33){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
			point_28.SetActive (true);
			point_29.SetActive (true);
			point_30.SetActive (true);
			point_31.SetActive (true);
			point_32.SetActive (true);
		}
		if(moneyPoints == 34){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
			point_28.SetActive (true);
			point_29.SetActive (true);
			point_30.SetActive (true);
			point_31.SetActive (true);
			point_32.SetActive (true);
			point_33.SetActive (true);
		}
		if(moneyPoints == 35){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
			point_28.SetActive (true);
			point_29.SetActive (true);
			point_30.SetActive (true);
			point_31.SetActive (true);
			point_32.SetActive (true);
			point_33.SetActive (true);
			point_34.SetActive (true);
		}
		if(moneyPoints == 36){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
			point_28.SetActive (true);
			point_29.SetActive (true);
			point_30.SetActive (true);
			point_31.SetActive (true);
			point_32.SetActive (true);
			point_33.SetActive (true);
			point_34.SetActive (true);
			point_35.SetActive (true);
		}
		if(moneyPoints == 37){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
			point_28.SetActive (true);
			point_29.SetActive (true);
			point_30.SetActive (true);
			point_31.SetActive (true);
			point_32.SetActive (true);
			point_33.SetActive (true);
			point_34.SetActive (true);
			point_35.SetActive (true);
			point_36.SetActive (true);
		}
		if(moneyPoints == 38){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
			point_28.SetActive (true);
			point_29.SetActive (true);
			point_30.SetActive (true);
			point_31.SetActive (true);
			point_32.SetActive (true);
			point_33.SetActive (true);
			point_34.SetActive (true);
			point_35.SetActive (true);
			point_36.SetActive (true);
			point_37.SetActive (true);
		}
		if(moneyPoints == 39){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
			point_28.SetActive (true);
			point_29.SetActive (true);
			point_30.SetActive (true);
			point_31.SetActive (true);
			point_32.SetActive (true);
			point_33.SetActive (true);
			point_34.SetActive (true);
			point_35.SetActive (true);
			point_36.SetActive (true);
			point_37.SetActive (true);
			point_38.SetActive (true);
		}
		if(moneyPoints == 40){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
			point_28.SetActive (true);
			point_29.SetActive (true);
			point_30.SetActive (true);
			point_31.SetActive (true);
			point_32.SetActive (true);
			point_33.SetActive (true);
			point_34.SetActive (true);
			point_35.SetActive (true);
			point_36.SetActive (true);
			point_37.SetActive (true);
			point_38.SetActive (true);
			point_39.SetActive (true);
		}
		if(moneyPoints == 41){
			anim.SetBool ("full", false);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
			point_28.SetActive (true);
			point_29.SetActive (true);
			point_30.SetActive (true);
			point_31.SetActive (true);
			point_32.SetActive (true);
			point_33.SetActive (true);
			point_34.SetActive (true);
			point_35.SetActive (true);
			point_36.SetActive (true);
			point_37.SetActive (true);
			point_38.SetActive (true);
			point_39.SetActive (true);
			point_40.SetActive (true);
		}
		if(moneyPoints >= 42){
			anim.SetBool ("full", true);
			point.SetActive (true);
			point_1.SetActive (true);
			point_2.SetActive (true);
			point_3.SetActive (true);
			point_4.SetActive (true);
			point_5.SetActive (true);
			point_6.SetActive (true);
			point_7.SetActive (true);
			point_8.SetActive (true);
			point_9.SetActive (true);
			point_10.SetActive (true);
			point_11.SetActive (true);
			point_12.SetActive (true);
			point_13.SetActive (true);
			point_14.SetActive (true);
			point_15.SetActive (true);
			point_16.SetActive (true);
			point_17.SetActive (true);
			point_18.SetActive (true);
			point_19.SetActive (true);
			point_20.SetActive (true);
			point_21.SetActive (true);
			point_22.SetActive (true);
			point_23.SetActive (true);
			point_24.SetActive (true);
			point_25.SetActive (true);
			point_26.SetActive (true);
			point_27.SetActive (true);
			point_28.SetActive (true);
			point_29.SetActive (true);
			point_30.SetActive (true);
			point_31.SetActive (true);
			point_32.SetActive (true);
			point_33.SetActive (true);
			point_34.SetActive (true);
			point_35.SetActive (true);
			point_36.SetActive (true);
			point_37.SetActive (true);
			point_38.SetActive (true);
			point_39.SetActive (true);
			point_40.SetActive (true);
			point_41.SetActive (true);
		}


	}

}
