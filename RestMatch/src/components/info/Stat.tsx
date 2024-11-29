import React from 'react';
import {imageUrl} from "@/utils/constants";

interface StatProps {
  icon: string;
  content: any;
  styles?: string;
}

const Stat = (props: StatProps) => {
  const {icon, content, styles} = props;
  return (
    <div className={`flex items-center text-4xl font-medium ${styles ? styles : ''}`}>
      <img src={`${imageUrl}/info/${icon}.png`} alt="info"/>
      <span className='ml-6'>{content}</span>
    </div>
  );
};

export default Stat;