import React from 'react';
import {imageUrl} from "@/utils/constants";
import Image from "next/image";
import styles from './header.module.scss'

const Header = () => {

  return (
    <header className='bg-[#875C2D] fixed top-0 left-0 right-0 h-[67px] z-30 w-full pt-[12px] pb-[15px] px-3'>
      <div className='flex justify-between h-full'>
        <Image width='139' height='34'  src={`${imageUrl}/header/logo.png`} alt="logo"/>
        <div className='flex gap-[27px]'>
          <button className={`${styles.headerButton}`}>Home page</button>
          <button className={`${styles.headerButton}`}>Let's match</button>
          <button className={`${styles.headerButton}`}>Research</button>
          <button className={`${styles.headerButton}`}>About us</button>
        </div>
        <button className={`${styles.headerButton}`}>Register</button>
      </div>
    </header>
  );
};

export default Header;