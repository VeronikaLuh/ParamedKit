import React from 'react';

interface InfoItemProps {
  title: string;
  description: string;
  buttonText: string | undefined;
}

const InfoItem = (props: InfoItemProps) => {
  const {title, description, buttonText} = props;
  return (
    <div className='bg-cyan-500 px-[34px] py-[26px]'
         style={{
           backgroundImage: 'url(assets/images/homepage/item-background.png)',
         }}>
      <h3 className='mb-[39px] font-bold'>{title}</h3>
      <p className='text-xl'>{description}</p>
      {buttonText &&
          <button className='mt-7 border-2 border-white text-2xl rounded-xl px-5 py-1 font-medium'>{buttonText}</button>
      }
    </div>
  );
};

export default InfoItem;