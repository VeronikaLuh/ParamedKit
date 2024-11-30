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
    <div
      className={`flex items-center text-sm font-medium ${
        styles ? styles : ""
      } md:text-4xl`}
    >
      <img
        className="scale-50 md:scale-100"
        src={`${imageUrl}/info/${icon}.png`}
        alt="info"
      />
      <span className="ml-2 md:ml-6 scale-100">{content}</span>
    </div>
  );
};

export default Stat;