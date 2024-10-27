import React from 'react';

interface InfoItemProps {
  title: string;
  description: string;
}

const InfoItem = (props: InfoItemProps) => {
  const {title, description} = props;
  return (
    <div className='bg-cyan-500 px-[34px] py-[26px]'
         style={{
           backgroundImage: 'url(assets/images/homepage/item-background.png)',
         }}>
      <h3 className='mb-[39px] font-bold'>{title}</h3>
      <p className='text-xl'>{description}</p>
      <button>Register</button>
    </div>
  );
};

export default InfoItem;